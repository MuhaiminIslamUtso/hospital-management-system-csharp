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
using System.Globalization;


namespace Hospital_Management_System
{
    public partial class Salary : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public Salary()
        {
            InitializeComponent();
            this.dgvSalaryDetails.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvSalaryDetails_RowPrePaint);
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            DateTime lastMonthDate = DateTime.Now.AddMonths(-1);
            int previousMonth = lastMonthDate.Month;
            int yearOfPreviousMonth = lastMonthDate.Year;

           
            if (!IsSalaryAlreadySavedForMonth(previousMonth, yearOfPreviousMonth))
            {
                
                SaveMonthlySalariesWithDeductions(previousMonth, yearOfPreviousMonth);
            }

            LoadSalaryDetails();
            CalculateTotals();
        }
        private bool IsSalaryAlreadySavedForMonth(int month, int year)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                
                string monthYearString = new DateTime(year, month, 1).ToString("MMM-yyyy", CultureInfo.InvariantCulture);
                string query = "SELECT COUNT(*) FROM SalaryDetails WHERE MonthYear = @monthYear";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@monthYear", monthYearString);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private void SaveMonthlySalariesWithDeductions(int month, int year)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    string monthYearString = new DateTime(year, month, 1).ToString("MMM-yyyy", CultureInfo.InvariantCulture);
                    string entryDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    int daysInMonth = DateTime.DaysInMonth(year, month);

                    
                    string doctorQuery = @"
                        INSERT INTO SalaryDetails (StaffType, StaffName, Salary, MonthYear, DoctorID, EntryDate)
                        SELECT 'Doctor', d.Name, d.Salary - (ISNULL(a.absentDays, 0) * (d.Salary / @DaysInMonth)), @monthYear, d.DoctorID, @entryDate
                        FROM Doctor d LEFT JOIN (
                            SELECT StaffID, COUNT(*) AS absentDays FROM Absence
                            WHERE StaffType = 'Doctor' AND MONTH(Date) = @TargetMonth AND YEAR(Date) = @TargetYear GROUP BY StaffID
                        ) a ON d.DoctorID = a.StaffID";

                    using (var cmd = new SqlCommand(doctorQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@monthYear", monthYearString);
                        cmd.Parameters.AddWithValue("@entryDate", entryDate);
                        cmd.Parameters.AddWithValue("@TargetMonth", month);
                        cmd.Parameters.AddWithValue("@TargetYear", year);
                        cmd.Parameters.AddWithValue("@DaysInMonth", daysInMonth);
                        cmd.ExecuteNonQuery();
                    }

                 

                    transaction.Commit();
                    MessageBox.Show($"Salaries for {monthYearString} processed with deductions.", "Payroll Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error processing payroll: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSalaryDetails()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT StaffType, StaffName, Salary, EntryDate FROM SalaryDetails ORDER BY EntryDate DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSalaryDetails.DataSource = dt;
            }
        }

        private int GetAbsenceCount(int staffId, string staffType)
        {
            using (var con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT COUNT(*) 
                    FROM Absence
                    WHERE StaffID = @StaffID 
                      AND StaffType = @StaffType 
                      AND MONTH(Date) = @CurrentMonth 
                      AND YEAR(Date) = @CurrentYear";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    cmd.Parameters.AddWithValue("@StaffType", staffType);
                    cmd.Parameters.AddWithValue("@CurrentMonth", DateTime.Now.Month);
                    cmd.Parameters.AddWithValue("@CurrentYear", DateTime.Now.Year);
                    con.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        private void dgvSalaryDetails_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.RowIndex == dgvSalaryDetails.NewRowIndex) return;

            try
            {
                var row = dgvSalaryDetails.Rows[e.RowIndex];
                string staffType = row.Cells["StaffType"].Value.ToString();
                int staffId = 0;

               
                if (staffType == "Doctor")
                    staffId = Convert.ToInt32(row.Cells["DoctorID"].Value);
                else if (staffType == "Nurse")
                    staffId = Convert.ToInt32(row.Cells["NurseID"].Value);
                else 
                    staffId = Convert.ToInt32(row.Cells["EmployeeID"].Value);

                if (staffId == 0) return;

                int absenceCount = GetAbsenceCount(staffId, staffType);

                if (absenceCount > 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (absenceCount > 3)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    
                    row.DefaultCellStyle.BackColor = dgvSalaryDetails.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = dgvSalaryDetails.DefaultCellStyle.ForeColor;
                }
            }
            catch (Exception)
            {
                
            }
        }


        private void CalculateTotals()
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmdDoctor = new SqlCommand("SELECT ISNULL(SUM(Salary), 0) FROM Doctor", con);
                txtDoctorSalary.Text = Convert.ToDecimal(cmdDoctor.ExecuteScalar()).ToString("N2");

                var cmdNurse = new SqlCommand("SELECT ISNULL(SUM(Salary), 0) FROM Nurse", con);
                txtNurseSalary.Text = Convert.ToDecimal(cmdNurse.ExecuteScalar()).ToString("N2");

                var cmdEmployee = new SqlCommand("SELECT ISNULL(SUM(Salary), 0) FROM Employee", con);
                txtEmployeeSalary.Text = Convert.ToDecimal(cmdEmployee.ExecuteScalar()).ToString("N2");

                decimal monthlySalary = Convert.ToDecimal(txtDoctorSalary.Text) + Convert.ToDecimal(txtNurseSalary.Text) + Convert.ToDecimal(txtEmployeeSalary.Text);

                txtMonthlySalary.Text = monthlySalary.ToString("N2");
                txtAllSalary.Text = monthlySalary.ToString("N2");
            }
        }


        private void dgvSalaryDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                LoadSalaryDetails();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Balance bl = new Balance();
            bl.Show();
            this.Hide();
        }
    }
}
