using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class RcTest : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public RcTest()
        {
            InitializeComponent();
        }

        private void RcTest_Load(object sender, EventArgs e)
        {
            // Start by showing only pnltestMaster
            pnltestMaster.BringToFront();
            pnltestMaster.Visible = true;
            pnlTesttopatient.Visible = false;
            //pnlViewtestResult.Visible = false;
            pnlTestBelling.Visible = false; 

            LoadPatients();
            LoadTests();
        }
        private void LoadPatients()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT PatientId, PatientName FROM Patient", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTestPatientName.DataSource = dt;
                cmbTestPatientName.DisplayMember = "PatientName";
                cmbTestPatientName.ValueMember = "PatientId";
            }
        }
        private void LoadTests()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TestID, TestName, TestCost FROM Test", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cblTest.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string testName = row["TestName"].ToString();
                    int cost = Convert.ToInt32(row["TestCost"]);
                    cblTest.Items.Add(new TestItem(testName, cost));
                }
            }
        }

        private void LoadPaidOrders()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT OrderID, PatientId, PatientName, TestNames, TotalCost, SerialNo, Status FROM TestOrder WHERE Status='Paid'", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTestBilling.DataSource = dt;
            }
        }
        private void LoadUnpaidOrders()
        { 
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT OrderID, PatientId, PatientName, TestNames, TotalCost, Email, Status FROM TestOrder WHERE Status='Unpaid'", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTestBilling.DataSource = dt;   // your DataGridView name
                    dgvTestBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // select entire row
                    dgvTestBilling.ReadOnly = true;   // prevent editing from grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error loading unpaid orders: " + ex.Message);
            }
        }






        private void btntp1_Click(object sender, EventArgs e)
        {
            // Show pnlTesttopatient and hide others
            pnlTesttopatient.BringToFront();
            pnlTesttopatient.Visible = true;
            pnltestMaster.Visible = false;
            //pnlViewtestResult.Visible = false;
            pnlTestBelling.Visible = false;
        }

        //private void btnTp2_Click_1(object sender, EventArgs e)
        //{
        //   // pnlViewtestResult.BringToFront();
        //    //pnlViewtestResult.Visible = true;
        //    pnltestMaster.Visible = false;
        //    pnlTesttopatient.Visible = false;
        //    pnlTestBelling.Visible = false;

        //}

        private void btnTMBack_Click(object sender, EventArgs e)
        {
            RcHome h2 = new RcHome();
            h2.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnltestMaster.BringToFront();
            pnltestMaster.Visible = true;
            pnlTesttopatient.Visible = false;
           // pnlViewtestResult.Visible = false;
        }

        //private void btnback1_Click(object sender, EventArgs e)
        //{
        //    // pnltestMaster.BringToFront();
        //    pnltestMaster.Visible = true;
        //    pnlTesttopatient.Visible = false;
        //   // pnlViewtestResult.Visible = false;
        //}

        private void btnTp3_Click(object sender, EventArgs e)
        {
            pnlTestBelling.Visible = true;
           // pnlViewtestResult.Visible = false;
            pnltestMaster.Visible = false;
            pnlTesttopatient.Visible = true;

            LoadUnpaidOrders();
        }

        //private void btnTestBackre_Click(object sender, EventArgs e)
        //{
        //    pnltestMaster.Visible = true;
        //    pnlTesttopatient.Visible = false;
        //   // pnlViewtestResult.Visible = false;
        //    pnlTestBelling.Visible = false;
        //}

        private void cmbTestPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTestPatientName.SelectedValue != null)
            {
                txtttppatientid.Text = cmbTestPatientName.SelectedValue.ToString();
            }
        }

        private void cblTest_SelectedIndexChanged(object sender, EventArgs e)

        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                CalculateCost();
            });
        }
        private void CalculateCost()
        {
            int totalCost = 0;
            int lastCost = 0;

            foreach (var item in cblTest.CheckedItems)
            {
                if (item is TestItem test)
                {
                    totalCost += test.Cost;
                    lastCost = test.Cost;
                }
            }

            
            txtttpTestCost.Text = lastCost.ToString();

           
            txtTotalTestCost.Text = totalCost.ToString();

            
            double discountPercent = 0;
            if (totalCost >= 10000)
                discountPercent = 10;
            else if (totalCost >= 8000)
                discountPercent = 8;
            else if (totalCost >= 5000)
                discountPercent = 5;

            txtTestDiscount.Text = discountPercent + "%";
        }

        public class TestItem
        {
            public string Name { get; set; }
            public int Cost { get; set; }

            public TestItem(string name, int cost)
            {
                Name = name;
                Cost = cost;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void btnTestToPatientSave_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtttppatientid.Text) || cblTest.CheckedItems.Count == 0)
                {
                    MessageBox.Show("⚠ Please select a patient and at least one test.");
                    return;
                }

                int patientId = int.Parse(txtttppatientid.Text);
                string patientName = cmbTestPatientName.Text;
                string email = txtttpContact.Text; 
                int totalCost = int.Parse(txtTotalTestCost.Text);

                
                string selectedTests = string.Join(", ",
                    cblTest.CheckedItems.Cast<TestItem>().Select(t => t.Name));

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(
                            "INSERT INTO TestOrder (PatientId, PatientName, TestNames, TotalCost, Email, Status, SerialNo) " +
                            "VALUES (@pid, @pname, @tests, @total, @mail, 'Unpaid', NULL)", con);

                        cmd.Parameters.AddWithValue("@pid", patientId);
                        cmd.Parameters.AddWithValue("@pname", patientName);
                        cmd.Parameters.AddWithValue("@tests", selectedTests);
                        cmd.Parameters.AddWithValue("@total", totalCost);
                        cmd.Parameters.AddWithValue("@mail", email);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Order saved successfully! Go to Billing panel to pay.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error saving order: " + ex.Message);
                }
            }
        }

     

       

       

         

       

        private void dgvTestBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTestpay_Click_1(object sender, EventArgs e)
        {
            if (dgvTestBilling.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠ Please select an order to pay.");
                return;
            }

            int orderId = Convert.ToInt32(dgvTestBilling.SelectedRows[0].Cells["OrderID"].Value);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to mark this order as Paid?",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                   
                    SqlCommand getSerialCmd = new SqlCommand(
                        "SELECT ISNULL(MAX(SerialNo), 0) + 1 FROM TestOrder WHERE Status='Paid'", con);
                    int nextSerial = (int)getSerialCmd.ExecuteScalar();

                 
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE TestOrder SET Status='Paid', SerialNo=@serial WHERE OrderID=@id", con);
                    cmd.Parameters.AddWithValue("@id", orderId);
                    cmd.Parameters.AddWithValue("@serial", nextSerial);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Payment successful! Serial No: " + nextSerial);

                        // 3. Refresh billing lists
                        LoadUnpaidOrders();
                        LoadPaidOrders();
                    }
                    else
                    {
                        MessageBox.Show("⚠ Order not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error while processing payment: " + ex.Message);
            }

        }

        private void btnTestPtintRecept_Click_1(object sender, EventArgs e)
        {
          
            DialogResult result = MessageBox.Show(
                "Do you want to view only PAID orders?",
                "Print Receipt",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                LoadPaidOrders();
                MessageBox.Show("📌 Showing only PAID orders. Now select one to print.");
                return; // stop here, user must select from filtered grid
            }

           
            if (dgvTestBilling.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠ Please select a PAID order to print.");
                return;
            }

            int orderId = Convert.ToInt32(dgvTestBilling.SelectedRows[0].Cells["OrderID"].Value);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand getOrderCmd = new SqlCommand(
                        "SELECT PatientName, TestNames, TotalCost, SerialNo, Status FROM TestOrder WHERE OrderID=@id", con);
                    getOrderCmd.Parameters.AddWithValue("@id", orderId);

                    SqlDataReader reader = getOrderCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["Status"].ToString() != "Paid")
                        {
                            MessageBox.Show("⚠ Receipt can only be printed for PAID orders.");
                            return;
                        }

                        string receipt = "🏥 Hospital Management System\n";
                        receipt += "-----------------------------\n";
                        receipt += $"Patient: {reader["PatientName"]}\n";
                        receipt += $"Tests: {reader["TestNames"]}\n";
                        receipt += $"Total Cost: {reader["TotalCost"]} Tk\n";
                        receipt += $"Serial No: {reader["SerialNo"]}\n";
                        receipt += $"Date: {DateTime.Now}\n";
                        receipt += "Status: Paid\n";
                        receipt += "-----------------------------\n";
                        receipt += "✅ Thank you for your payment!\n";

                        FrmReceipt frm = new FrmReceipt(receipt);
                        frm.ShowDialog();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error printing receipt: " + ex.Message);
            }
        }

        private void btnRefreshre_Click(object sender, EventArgs e)
        {
            LoadUnpaidOrders();  // reload unpaid orders into dgvTestBilling
            MessageBox.Show("🔄 Billing list refreshed.");
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            pnlTestBelling.Visible = false;
            pnltestMaster.Visible = true;
            pnlTesttopatient.Visible = false;
        }
    }
}






