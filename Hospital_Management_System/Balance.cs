using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Globalization;

namespace Hospital_Management_System
{
    public partial class Balance : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        private readonly PrintDocument printDocument = new PrintDocument();
        private readonly PrintPreviewDialog previewDialog = new PrintPreviewDialog();
        private int currentRow = 0;
        public Balance()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;
            previewDialog.Document = printDocument;
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = new Size(720, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            LoadBalance(allTime: true);
        }
        private void LoadBalance(DateTime? fromDate = null, DateTime? toDate = null, bool allTime = true)
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    string query = @"
                        WITH FinancialEntries AS (
                            -- Income from patient payments
                            SELECT
                                'Income' AS Type,
                                'Patient Payment (' + p.PatientName + ')' AS Description,
                                pay.PaidAmount AS Amount,
                                pay.PaymentDate AS EntryDate
                            FROM Payments pay
                            JOIN Patient p ON pay.PatientID = p.PatientID
                            WHERE pay.PaymentDate IS NOT NULL

                            UNION ALL

                            -- Expenses from staff salaries
                            SELECT
                                'Salary - ' + sd.StaffType AS Type,
                                sd.StaffName AS Description,
                                sd.Salary * -1 AS Amount, -- Expenses are negative
                                sd.EntryDate
                            FROM SalaryDetails sd
                            WHERE sd.EntryDate IS NOT NULL

                            UNION ALL

                            -- Manual expenses from BalanceDetails
                            SELECT
                                bd.Type,
                                bd.Description,
                                bd.Amount * -1 AS Amount, -- Expenses are negative
                                bd.EntryDate
                            FROM BalanceDetails bd
                        )
                        SELECT
                            Type,
                            Description,
                            Amount,
                            EntryDate
                        FROM FinancialEntries
                        {0} -- Date filter placeholder
                        ORDER BY EntryDate DESC;";

                    string whereClause = "";
                    if (!allTime && fromDate.HasValue && toDate.HasValue)
                    {
                        whereClause = "WHERE EntryDate >= @from AND EntryDate < @to";
                    }

                    query = string.Format(query, whereClause);

                    using (var cmd = new SqlCommand(query, con))
                    {
                        if (!allTime && fromDate.HasValue && toDate.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@from", fromDate.Value.Date);
                            cmd.Parameters.AddWithValue("@to", toDate.Value.Date.AddDays(1));
                        }

                        var da = new SqlDataAdapter(cmd);
                        var dt = new DataTable();
                        da.Fill(dt);

                        dgvHBalance.DataSource = dt;
                        FormatGrid();

                        decimal totalIncome = dt.AsEnumerable()
                            .Where(r => r["Amount"] != DBNull.Value && Convert.ToDecimal(r["Amount"]) > 0)
                            .Sum(r => Convert.ToDecimal(r["Amount"]));

                        decimal totalExpenses = dt.AsEnumerable()
                            .Where(r => r["Amount"] != DBNull.Value && Convert.ToDecimal(r["Amount"]) < 0)
                            .Sum(r => Convert.ToDecimal(r["Amount"]));

                        decimal balance = totalIncome + totalExpenses;

                        var culture = new CultureInfo("bn-BD");
                        txtTotalIncome.Text = totalIncome.ToString("C", culture);
                        txtExpenses.Text = (totalExpenses * -1).ToString("C", culture);
                        txtBalance.Text = balance.ToString("C", culture);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading balance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormatGrid()
        {
            if (dgvHBalance.Columns.Count == 0) return;

            var culture = new CultureInfo("bn-BD");

            // Set currency and date formatting
            dgvHBalance.Columns["Amount"].DefaultCellStyle.Format = "C";
            dgvHBalance.Columns["Amount"].DefaultCellStyle.FormatProvider = culture;
            dgvHBalance.Columns["EntryDate"].DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm tt";

            // This line tells the columns to stretch to fill the grid's width.
            // If you remove the FillWeight lines, each column will get an equal share of the space.
            dgvHBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set row colors based on income or expense
            foreach (DataGridViewRow row in dgvHBalance.Rows)
            {
                if (row.Cells["Amount"].Value != DBNull.Value)
                {
                    decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);
                    row.DefaultCellStyle.BackColor = amount > 0 ? Color.LightGreen : Color.LightSalmon;
                }
            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            LoadBalance(dtpFrom.Value, dtpTo.Value, chkAllTime.Checked);

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        { // 1. Validate the input from the single expense textbox.
            if (!decimal.TryParse(txtManualExpense.Text, out decimal expenseAmount) || expenseAmount <= 0)
            {
                MessageBox.Show("Please enter a valid, positive expense amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // 2. This is the corrected SQL query.
                    const string query = @"
                INSERT INTO BalanceDetails (Type, Description, Amount, EntryDate, PatientID, EmployeeID, DoctorID, NurseID)
                VALUES (@type, @desc, @amount, @date, @patientId, @employeeId, @doctorId, @nurseId)";

                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@type", "Manual Expense");
                        // 3. A default description is now used.
                        cmd.Parameters.AddWithValue("@desc", "Manual expense added by Admin");
                        cmd.Parameters.AddWithValue("@amount", expenseAmount);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        // Pass DBNull.Value for all optional foreign keys
                        cmd.Parameters.AddWithValue("@patientId", DBNull.Value);
                        cmd.Parameters.AddWithValue("@employeeId", DBNull.Value);
                        cmd.Parameters.AddWithValue("@doctorId", DBNull.Value);
                        cmd.Parameters.AddWithValue("@nurseId", DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Manual expense added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Refresh the grid and clear the single textbox.
                LoadBalance(allTime: true);
                txtManualExpense.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding expense: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBalance(allTime: true);
            chkAllTime.Checked = true;
        }

        private void btnSALARY_Click(object sender, EventArgs e)
        {
            Salary sl = new Salary();
            sl.Show();
            this.Hide();
        }

        private void dgvHBalance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AdHome homeForm)
                {
                    homeForm.Show();
                    this.Hide();

                    if (homeForm.Controls["pnladdes"] is Panel pnl)
                        pnl.Visible = true;

                    return;
                }
            }




        }

        private void btnpeient_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            previewDialog.WindowState = FormWindowState.Maximized;
            previewDialog.ShowDialog();

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                int y = e.MarginBounds.Top;
                int leftMargin = e.MarginBounds.Left;
                int rightMargin = e.MarginBounds.Right;

                // --- Fonts and Culture ---
                Font titleFont = new Font("Arial", 18, FontStyle.Bold);
                Font headerFont = new Font("Arial", 10, FontStyle.Bold);
                Font cellFont = new Font("Arial", 10);
                Font footerFont = new Font("Arial", 9, FontStyle.Italic);
                var culture = new CultureInfo("bn-BD");

                // --- Report Title ---
                g.DrawString("Hospital Balance Report", titleFont, Brushes.Black, leftMargin, y);
                y += 50;

                // --- Column Headers ---
                string[] headers = { "Type", "Description", "Amount", "Entry Date" };
                int[] colWidths = { 150, 300, 120, 180 };
                int x = leftMargin;

                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawString(headers[i], headerFont, Brushes.Black, x, y);
                    x += colWidths[i];
                }
                y += 25;

                // ✅ Fixed line drawing
                g.DrawLine(Pens.Black, leftMargin, y, rightMargin, y);
                y += 10;

                // --- Data Rows with Highlighting ---
                while (currentRow < dgvHBalance.Rows.Count)
                {
                    DataGridViewRow row = dgvHBalance.Rows[currentRow];
                    if (row.IsNewRow) { currentRow++; continue; }

                    // Check if there's enough space on the page for another row
                    if (y + cellFont.Height > e.MarginBounds.Bottom - 100) // keep space for footer
                    {
                        e.HasMorePages = true; // Tell the printer there's another page
                        return; // Stop drawing on this page
                    }

                    decimal amountValue = Convert.ToDecimal(row.Cells["Amount"].Value);
                    Brush rowBrush = amountValue > 0 ? Brushes.LightGreen : Brushes.LightSalmon;
                    g.FillRectangle(rowBrush, leftMargin, y, rightMargin - leftMargin, cellFont.Height + 5);

                   
                    x = leftMargin;
                    string type = row.Cells["Type"].Value?.ToString() ?? "";
                    string description = row.Cells["Description"].Value?.ToString() ?? "";
                    string amount = amountValue.ToString("C", culture);
                    string entryDate = Convert.ToDateTime(row.Cells["EntryDate"].Value).ToString("dd-MMM-yyyy hh:mm tt");

                    g.DrawString(type, cellFont, Brushes.Black, x, y + 2);
                    x += colWidths[0];
                    g.DrawString(description, cellFont, Brushes.Black, x, y + 2);
                    x += colWidths[1];
                    g.DrawString(amount, cellFont, Brushes.Black, x, y + 2);
                    x += colWidths[2];
                    g.DrawString(entryDate, cellFont, Brushes.Black, x, y + 2);

                    y += 25;
                    currentRow++;
                }

                // --- Summary Totals ---
                y += 30;
                g.DrawLine(Pens.Black, leftMargin, y, rightMargin, y); 
                y += 20;

                g.DrawString($"Total Income: {txtTotalIncome.Text}", cellFont, Brushes.DarkGreen, leftMargin, y);
                y += 20;
                g.DrawString($"Total Expenses: {txtExpenses.Text}", cellFont, Brushes.DarkRed, leftMargin, y);
                y += 20;
                g.DrawString($"Balance: {txtBalance.Text}", headerFont, Brushes.Blue, leftMargin, y);
                y += 40;

                
                try
                {
                    TimeZoneInfo bstZone = TimeZoneInfo.FindSystemTimeZoneById("Bangladesh Standard Time");
                    DateTime bstTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, bstZone);
                    string printDate = $"Printed on: {bstTime:dd-MM-yyyy hh:mm tt}";
                    SizeF printDateSize = g.MeasureString(printDate, footerFont);

                    g.FillRectangle(Brushes.LightGray, leftMargin, y, printDateSize.Width + 10, printDateSize.Height + 5);
                    g.DrawString(printDate, footerFont, Brushes.Black, leftMargin + 5, y + 2);
                }
                catch (TimeZoneNotFoundException)
                {
                    g.DrawString($"Printed on: {DateTime.Now:dd-MM-yyyy hh:mm tt}", footerFont, Brushes.Black, leftMargin, y);
                }

                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A critical error occurred while generating the print page: " + ex.Message,
                    "Print Page Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlshow_Paint(object sender, PaintEventArgs e)
        {
         
            decimal balance = 0;
            try
            {
                
                string balanceText = txtBalance.Text.Replace("৳", "").Replace(",", "");
                balance = Convert.ToDecimal(balanceText);
            }
            catch (FormatException)
            {
               
                pnlshow.Visible = false;
                return;
            }

           
            pnlshow.Visible = true;

           
            if (balance < 0)
            {

                //pnlshow.BackColor = Color.Red;
                pnlshow.BackColor = Color.FromArgb(255, 0, 127);
                lblShow.ForeColor = Color.White;
                lblShow.Text = "DANGER! Your hospital's finances are critical! ৳";
            }
            else
            {
                
               pnlshow.BackColor = Color.Green;
                lblShow.ForeColor = Color.White;
                lblShow.Text = "Excellent! Your hospital's finances are healthy! Tk";
            }
        }

    }
}

