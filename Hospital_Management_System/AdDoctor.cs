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
    public partial class AdDoctor : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public AdDoctor()
        {
            InitializeComponent();
            dvgDoctor.Hide();
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = new Size(720, 590);
        }

        private void btnDCBack_Click(object sender, EventArgs e)
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

        private void txtDcLicenseID_TextChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(1000, 10000);
            txtDcLicenceID.Text = id.ToString();
        }



        private void AdDoctor_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            GenerateDoctorLicenseID();
        }
        private void GenerateDoctorLicenseID()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT ISNULL(MAX(CAST(DoctorLicenseID as int)), 999) + 1 FROM Doctor", con);

                    int newId = (int)cmd.ExecuteScalar();
                    txtDcLicenceID.Text = newId.ToString("D4");
                    dvgDoctor.ScrollBars = ScrollBars.Both;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Doctor  License ID: " + ex.Message);
            }
        }
        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doctor", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvgDoctor.AutoGenerateColumns = true;
                    dvgDoctor.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }

        private void btnDCSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                         "INSERT INTO Doctor(Name, JoningDate, DoctorLicenseID, Age, Gender, Salary, Specialization, EmergencyContact, Email, WorkingTime, AppointmentCapability) " +
                         "VALUES(@name, @jdate, @lic, @age, @gender, @salary, @spec, @emergency, @email, @worktime, @capacity)", con);

                    cmd.Parameters.AddWithValue("@name", txtdcName.Text);
                   
                    cmd.Parameters.AddWithValue("@jdate", dtpdc.Value);
                    cmd.Parameters.AddWithValue("@lic", txtDcLicenceID.Text);
                    cmd.Parameters.AddWithValue("@age", textdcage.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@salary", txrDcSalary.Text);
                    cmd.Parameters.AddWithValue("@spec", cmbSpecilization.Text);
                    cmd.Parameters.AddWithValue("@emergency", txtdcEmargancyContact1.Text);
                    cmd.Parameters.AddWithValue("@email", txtdcEmail.Text);
                    cmd.Parameters.AddWithValue("@worktime", cmbdcWorkingTime.Text);
                    cmd.Parameters.AddWithValue("@capacity", txtdcAppointCap.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Doctor saved successfully");

                    LoadDoctors();
                    GenerateDoctorLicenseID();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while saving: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDoUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Doctor SET Name=@name, JoningDate=@jdate, Age=@age, Gender=@gender, Salary=@salary, Specialization=@spec, EmergencyContact=@emergency, Email=@email, WorkingTime=@worktime, AppointmentCapability=@capacity " +
                        "WHERE DoctorID=@docid", con);

                    cmd.Parameters.AddWithValue("@name", txtdcName.Text);
                    cmd.Parameters.AddWithValue("@jdate", dtpdc.Value);
                    cmd.Parameters.AddWithValue("@age", textdcage.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@salary", txrDcSalary.Text);
                    cmd.Parameters.AddWithValue("@spec", cmbSpecilization.Text);
                    cmd.Parameters.AddWithValue("@emergency", txtdcEmargancyContact1.Text);
                    cmd.Parameters.AddWithValue("@email", txtdcEmail.Text);
                    cmd.Parameters.AddWithValue("@worktime", cmbdcWorkingTime.Text);
                    cmd.Parameters.AddWithValue("@capacity", txtdcAppointCap.Text);
                    cmd.Parameters.AddWithValue("@docid", txtDoctorID.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Doctor updated successfully" : "⚠ No doctor found");

                    LoadDoctors();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while updating: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Doctor WHERE DoctorID=@docid", con);
                    cmd.Parameters.AddWithValue("@docid", txtDoctorID.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Doctor deleted successfully" : "⚠ No doctor found");

                    LoadDoctors();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while deleting: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDoclear_Click(object sender, EventArgs e)
        {
            txtdcName.Clear();
            txtDoctorID.Clear();
            txtDcLicenceID.Clear();
            textdcage.Clear();
            txtdcEmargancyContact1.Clear();
            txtdcEmail.Clear();
            cmbGender.SelectedIndex = -1;
            txrDcSalary.Clear();
            cmbSpecilization.SelectedIndex = -1;
            cmbdcWorkingTime.SelectedIndex = -1;
            txtdcAppointCap.Clear();
            dtpdc.Value = DateTime.Now;

            GenerateDoctorLicenseID();
        }

        private void dvgDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgDoctor.Rows[e.RowIndex];

                txtdcName.Text = row.Cells["Name"].Value.ToString();
                txtDoctorID.Text = row.Cells["DoctorID"].Value.ToString();
                dtpdc.Value = Convert.ToDateTime(row.Cells["JoningDate"].Value);
                txtDcLicenceID.Text = row.Cells["DoctorLicenseID"].Value.ToString();
                textdcage.Text = row.Cells["Age"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                txrDcSalary.Text = row.Cells["Salary"].Value.ToString();
                cmbSpecilization.Text = row.Cells["Specialization"].Value.ToString();
                txtdcEmargancyContact1.Text = row.Cells["EmergencyContact"].Value.ToString();
                txtdcEmail.Text = row.Cells["Email"].Value.ToString();
                cmbdcWorkingTime.Text = row.Cells["WorkingTime"].Value.ToString();
                txtdcAppointCap.Text = row.Cells["AppointmentCapability"].Value.ToString();
            }
        }

        private void btnDcShowDetails_Click_1(object sender, EventArgs e)
        {
            dvgDoctor.Show();   
            LoadDoctors();


        }

        private void btnDocSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT * FROM Doctor 
                             WHERE Name LIKE @search 
                                OR DoctorID LIKE @search 
                                OR DoctorLicenseID LIKE @search 
                                OR Email LIKE @search 
                                OR WorkingTime LIKE @search 
                                OR AppointmentCapability LIKE @search";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@search", "%" + txtDoctorID.Text.Trim() + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvgDoctor.AutoGenerateColumns = true;
                    dvgDoctor.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("⚠ No matching doctor found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }

        private void txtDcLicenceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

      
    }

