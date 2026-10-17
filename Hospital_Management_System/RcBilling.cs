using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;


namespace Hospital_Management_System
{

    public partial class RcBilling : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        private readonly PrintDocument printDocument = new PrintDocument();
        private string slipText = "";
        public RcBilling()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;
            // Wire up the SelectionChanged event to update textboxes when a grid row is selected.
            dvgpatientBill.SelectionChanged += dvgpatientBill_SelectionChanged;
        }

        private void btnTestBackre_Click(object sender, EventArgs e)
        {
            var h2 = new RcHome();
            h2.Show();
            this.Hide();
        }

        private void RcBilling_Load(object sender, EventArgs e)

        {
            // Use 'using' for proper resource management
            using (var con = new SqlConnection(connectionString))
            {
                var da = new SqlDataAdapter("SELECT PatientID, PatientName FROM Patient", con);
                var dt = new DataTable();
                da.Fill(dt);
                cmbBillPAID.DataSource = dt;
                cmbBillPAID.DisplayMember = "PatientID";
                cmbBillPAID.ValueMember = "PatientID";
            }
            LoadPayments();
            // Clear selection and textboxes for a clean start
            cmbBillPAID.SelectedIndex = -1;
            ClearTextBoxes();
        }




        private void cmbBillPAID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This event can fire with a null value when the form loads. This guard prevents errors.
            if (cmbBillPAID.SelectedValue == null) return;
            if (int.TryParse(cmbBillPAID.SelectedValue.ToString(), out int patientId))
            {
                LoadPatientBillingInfo(patientId);
            }
        }

        private void LoadPatientBillingInfo(int PatientID)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                const string query = @"
                    WITH PatientTotals AS (
                        SELECT
                            P.PatientName,
                            TotalCost = ISNULL((SELECT SUM(Cost) FROM Appointment WHERE PatientID = P.PatientID), 0) +
                                        ISNULL((SELECT SUM(TotalCost) FROM Booking WHERE PatientID = P.PatientID), 0) +
                                        ISNULL((SELECT SUM(TotalCost) FROM TestOrder WHERE PatientID = P.PatientID), 0),
                            PaidAmount = ISNULL((SELECT SUM(PaidAmount) FROM Payments WHERE PatientID = P.PatientID), 0)
                        FROM Patient P
                        WHERE P.PatientID = @pid
                    )
                    SELECT PatientName, TotalCost, PaidAmount, DueAmount = TotalCost - PaidAmount
                    FROM PatientTotals;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@pid", SqlDbType.Int).Value = PatientID;
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtPNBilling.Text = dr["PatientName"].ToString();
                            decimal total = Convert.ToDecimal(dr["TotalCost"]);
                            decimal paid = Convert.ToDecimal(dr["PaidAmount"]);
                            decimal due = total - paid;

                            txtTCost.Text = total.ToString("F2");
                            txtBillPaid.Text = paid.ToString("F2");
                            txtUnpaid.Text = Math.Max(0m, due).ToString("F2");
                        }
                        else
                        {
                            // If patient not found, clear the textboxes
                            ClearTextBoxes();
                        }
                    }
                }
            }
        }
                
            
        private void btnBillingPay_Click(object sender, EventArgs e)
        {


            try
            {
                if (cmbBillPAID.SelectedValue == null || !int.TryParse(cmbBillPAID.SelectedValue.ToString(), out int patientId))
                {
                    MessageBox.Show("Please select a valid Patient ID.");
                    return;
                }

                decimal.TryParse(txtTCost.Text, out decimal totalAmount);
                decimal.TryParse(txtBillPaid.Text, out decimal alreadyPaid);
                decimal.TryParse(txtUnpaid.Text, out decimal requestPay);

                decimal remainingDue = Math.Max(0m, totalAmount - alreadyPaid);
                if (remainingDue <= 0m)
                {
                    MessageBox.Show("No unpaid balance to pay.");
                    return;
                }

                decimal payNow = Math.Min(remainingDue, requestPay);
                if (payNow <= 0)
                {
                    MessageBox.Show("The amount to pay must be positive.");
                    return;
                }

                if (MessageBox.Show($"Confirm payment of {payNow:C}?", "Confirm Payment", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                // 'using' block for the payment connection
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    decimal dueAfterPayment = remainingDue - payNow;
                    string status = dueAfterPayment <= 0m ? "Paid" : "Due";

                    const string insertQuery = @"
                        INSERT INTO Payments (PatientID, PatientName, TotalAmount, PaidAmount, DueAmount, Status, PaymentDate)
                        VALUES (@PatientID, @PatientName, @TotalAmount, @PaidAmount, @DueAmount, @Status, GETDATE());";

                    using (var cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = patientId;
                        cmd.Parameters.Add("@PatientName", SqlDbType.NVarChar, 200).Value = txtPNBilling.Text;
                        cmd.Parameters.Add("@TotalAmount", SqlDbType.Money).Value = totalAmount;
                        cmd.Parameters.Add("@PaidAmount", SqlDbType.Money).Value = payNow;
                        cmd.Parameters.Add("@DueAmount", SqlDbType.Money).Value = dueAfterPayment;
                        cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = status;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Payment successful!");
                LoadPatientBillingInfo(patientId);
                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while making payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadPayments() {

            try
            {
                // 'using' block for the grid-loading connection
                using (var con = new SqlConnection(connectionString))
                {
                    const string query = @"
                        WITH Aggregates AS (
                            SELECT
                                P.PatientID,
                                P.PatientName,
                                TotalAmount = ISNULL((SELECT SUM(Cost) FROM Appointment WHERE PatientID = P.PatientID), 0) +
                                            ISNULL((SELECT SUM(TotalCost) FROM Booking WHERE PatientID = P.PatientID), 0) +
                                            ISNULL((SELECT SUM(TotalCost) FROM TestOrder WHERE PatientID = P.PatientID), 0),
                                PaidAmount = ISNULL((SELECT SUM(PaidAmount) FROM Payments WHERE PatientID = P.PatientID), 0)
                            FROM Patient P
                        )
                        SELECT
                            PatientID,
                            PatientName,
                            TotalAmount,
                            PaidAmount,
                            DueAmount = CASE WHEN TotalAmount - PaidAmount < 0 THEN 0 ELSE TotalAmount - PaidAmount END,
                            Status = CASE WHEN TotalAmount - PaidAmount <= 0 THEN 'Paid' ELSE 'Due' END
                        FROM Aggregates;";

                    var da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dvgpatientBill.DataSource = dt;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dvgpatientBill_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgpatientBill.SelectedRows.Count == 0) return;
            var row = dvgpatientBill.SelectedRows[0];

            if (row.Cells["PatientID"].Value != null && int.TryParse(row.Cells["PatientID"].Value.ToString(), out int patientId))
            {
                cmbBillPAID.SelectedValue = patientId;
                txtPNBilling.Text = row.Cells["PatientName"].Value.ToString();
                txtTCost.Text = Convert.ToDecimal(row.Cells["TotalAmount"].Value).ToString("F2");
                txtBillPaid.Text = Convert.ToDecimal(row.Cells["PaidAmount"].Value).ToString("F2");
                txtUnpaid.Text = Convert.ToDecimal(row.Cells["DueAmount"].Value).ToString("F2");
            }
        }




        private void btnrtestSearch_Click(object sender, EventArgs e)
        {
            if (cmbBillPAID.SelectedValue == null || !int.TryParse(cmbBillPAID.SelectedValue.ToString(), out int patientId))
            {
                MessageBox.Show("Please select a Patient ID to search for.");
                return;
            }

            foreach (DataGridViewRow row in dvgpatientBill.Rows)
            {
                if (row.Cells["PatientID"].Value != null && Convert.ToInt32(row.Cells["PatientID"].Value) == patientId)
                {
                    row.Selected = true;
                    dvgpatientBill.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
            MessageBox.Show("Patient ID not found in the list.");
        }






        private void btnTestRefreshre_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPayments();
                ClearTextBoxes();
                cmbBillPAID.SelectedIndex = -1;
                MessageBox.Show("Data refreshed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBoxes()
        {
            //txtPNBilling.Clear();
            //txtTCost.Clear();
            //txtBillPaid.Clear();
            txtUnpaid.Clear();
        }

        private void btnPramentSlip_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgpatientBill.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Patient row first.");
                    return;
                }
                DataGridViewRow row = dvgpatientBill.SelectedRows[0];
                string patientID = row.Cells["PatientID"].Value.ToString();
                string patientName = row.Cells["PatientName"].Value.ToString();

                // 1. Format currency with the Bangladeshi Taka symbol (৳)
                var cultureInfo = new System.Globalization.CultureInfo("bn-BD");
                string totalAmount = Convert.ToDecimal(row.Cells["TotalAmount"].Value).ToString("C", cultureInfo);
                string paidAmount = Convert.ToDecimal(row.Cells["PaidAmount"].Value).ToString("C", cultureInfo);
                string dueAmount = Convert.ToDecimal(row.Cells["DueAmount"].Value).ToString("C", cultureInfo);

                // 2. Get the current time and convert it to Bangladesh Standard Time
                TimeZoneInfo bstZone = TimeZoneInfo.FindSystemTimeZoneById("Bangladesh Standard Time");
                DateTime bstTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, bstZone);

                slipText =
                    "------ Hospital Payment Slip ------\n\n" +
                    $"Patient ID   : {patientID}\n" +
                    $"Patient Name : {patientName}\n" +
                    $"Total Amount : {totalAmount}\n" + // Now shows ৳
                    $"Paid Amount  : {paidAmount}\n" +  // Now shows ৳
                    $"Due Amount   : {dueAmount}\n" +   // Now shows ৳
                    $"Date         : {bstTime:dd-MM-yyyy hh:mm tt}\n\n" + // Shows Bangladesh time
                    "------------------------------";

                DialogResult result = MessageBox.Show(
                    slipText + "\n\nDo you want to print this slip?",
                    "Payment Slip",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    using (var pd = new PrintDialog { Document = printDocument })
                    {
                        if (pd.ShowDialog() == DialogResult.OK)
                        {
                            printDocument.Print();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while printing slip: " + ex.Message);
            }
        }



        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            e.Graphics.DrawString(slipText, new Font("Consolas", 12), Brushes.Black, new PointF(100, 100));
        }
        

    }
}


