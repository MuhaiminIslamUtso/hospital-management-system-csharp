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

namespace Hospital_Management_System
{
    public partial class Absence : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public Absence()
        {
            InitializeComponent();
            this.Load += Absence_Load;
            this.cmbStaffName.SelectedIndexChanged += new System.EventHandler(this.cmbStaffName_SelectedIndexChanged);
        }

        private void Absence_Load(object sender, EventArgs e)
        {
            // Populate the Staff Type ComboBox
            cmbStaffType.Items.Clear();
            cmbStaffType.Items.Add("Doctor");
            cmbStaffType.Items.Add("Nurse");
            cmbStaffType.Items.Add("Employee");

            // Set the custom date format for the input control
            dtpAbsenceDate.Format = DateTimePickerFormat.Custom;
            dtpAbsenceDate.CustomFormat = "dd MMMM yyyy";
        }

        private void btnBackH_Click(object sender, EventArgs e)
        {
            RcHome h3 = new RcHome();
            h3.Show();
            this.Hide();
        }

        private void cmbStaffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStaffType.SelectedItem == null)
            {
                cmbStaffName.DataSource = null;
                txtshowID.Clear();
                return;
            }

            string staffType = cmbStaffType.SelectedItem.ToString();
            string query = "", idColumn = "", nameColumn = "";

            switch (staffType)
            {
                case "Doctor":
                    query = "SELECT DoctorID, Name FROM Doctor ORDER BY Name";
                    idColumn = "DoctorID"; nameColumn = "Name";
                    break;
                case "Nurse":
                    query = "SELECT NurseID, Name FROM Nurse ORDER BY Name";
                    idColumn = "NurseID"; nameColumn = "Name";
                    break;
                case "Employee":
                    query = "SELECT EmployeeID, EmployeeName FROM Employee ORDER BY EmployeeName";
                    idColumn = "EmployeeID"; nameColumn = "EmployeeName";
                    break;
            }

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    cmbStaffName.DataSource = dt;
                    cmbStaffName.DisplayMember = nameColumn;
                    cmbStaffName.ValueMember = idColumn;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message);
            }
        }
        private void cmbStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmbStaffName.SelectedValue != null)
            {
              
              
                txtshowID.Text = cmbStaffName.SelectedValue.ToString();
            }
            else
            {
                txtshowID.Clear();
            }
        }


        private void btnMarkAbsent_Click(object sender, EventArgs e)
        {

            if (cmbStaffType.SelectedItem == null || cmbStaffName.SelectedValue == null)
            {
                MessageBox.Show("Please select a staff member.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string staffType = cmbStaffType.SelectedItem.ToString();
            int staffId = Convert.ToInt32(cmbStaffName.SelectedValue);
            DateTime date = dtpAbsenceDate.Value.Date;
            

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Absence WHERE StaffID = @StaffID AND StaffType = @StaffType AND Date = @Date";
                    var checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@StaffID", staffId);
                    checkCmd.Parameters.AddWithValue("@StaffType", staffType);
                    checkCmd.Parameters.AddWithValue("@Date", date);

                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("This staff member is already marked absent for this date.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    string insertQuery = "INSERT INTO Absence (StaffID, StaffType, Date) VALUES (@StaffID, @StaffType, @Date)";
                    var insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@StaffID", staffId);
                    insertCmd.Parameters.AddWithValue("@StaffType", staffType);
                    insertCmd.Parameters.AddWithValue("@Date", date);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Absence successfully logged.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging absence: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    string query = "SELECT StaffType, StaffID, Date FROM Absence ORDER BY Date DESC";
                    var da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvAbsenceHistory.DataSource = dt;
                    dgvAbsenceHistory.Columns["Date"].DefaultCellStyle.Format = "dd MMMM yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching absence history: " + ex.Message);
            }
        }

        //private void Absence_Load(object sender, EventArgs e)
        //{
        //    cmbStaffType.Items.Clear();
        //    cmbStaffType.Items.Add("Doctor");
        //    cmbStaffType.Items.Add("Nurse");
        //    cmbStaffType.Items.Add("Employee");
        //    dtpAbsenceDate.Format = DateTimePickerFormat.Custom;
        //    dtpAbsenceDate.CustomFormat = "dd MMMM yyyy";
        //}

       
    }
}
    

