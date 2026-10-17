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
    public partial class RcAppointment : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public RcAppointment()
        {
            InitializeComponent();
        }

        private void btnappmBack_Click(object sender, EventArgs e)
        {
            RcHome h3 = new RcHome();
            h3.Show();
            this.Hide();
        }

        private void cmbappStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RcAppointment_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadPatients();

            cmbDoctor.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
            cmbPatient.SelectedIndexChanged += cmbPatient_SelectedIndexChanged;
        }

        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DoctorID, Name FROM Doctor", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbDoctor.DisplayMember = "Name";     
                    cmbDoctor.ValueMember = "DoctorID";   
                    cmbDoctor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }
        private void LoadPatients()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT PatientId, PatientName FROM Patient", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbPatient.DisplayMember = "PatientName";    
                    cmbPatient.ValueMember = "PatientId"; 
                    cmbPatient.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }
        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedValue != null)
            {
                string doctorId = cmbDoctor.SelectedValue.ToString();  

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT DoctorID, WorkingTime, AppointmentCapability FROM Doctor WHERE DoctorID=@docid", con);
                        cmd.Parameters.AddWithValue("@docid", doctorId);

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            txtDoctorId.Text = dr["DoctorID"].ToString();
                            txtSchedule.Text = dr["WorkingTime"].ToString();
                            txtperday.Text = dr["AppointmentCapability"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctor info: " + ex.Message);
                }
            }
        }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue != null)
            {
                string patientId = cmbPatient.SelectedValue.ToString(); 

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT PatientId, MajorDeases FROM Patient WHERE PatientId=@pid", con);
                        cmd.Parameters.AddWithValue("@pid", patientId);

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            txtappPId.Text = dr["PatientId"].ToString();
                            txtMJ.Text = dr["MajorDeases"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient info: " + ex.Message);
                }
            }
        }

        private void btnApptApply_Click(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedValue == null || string.IsNullOrWhiteSpace(txtDoctorId.Text))
            {
                MessageBox.Show("Please select a Doctor.");
                return;
            }

           
            if (cmbPatient.SelectedValue == null || string.IsNullOrWhiteSpace(txtappPId.Text))
            {
                MessageBox.Show("Please select a Patient.");
                return;
            }

           
            if (string.IsNullOrWhiteSpace(txtMJ.Text))
            {
                MessageBox.Show("Please enter Major Disease information.");
                return;
            }

            if (dtpapp.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a valid appointment date (today or future).");
                return;
            }

           
            string doctorId = cmbDoctor.SelectedValue.ToString();
            DateTime selectedDate = dtpapp.Value.Date;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    SqlCommand cmd = new SqlCommand(
                        @"SELECT COUNT(*) 
                  FROM Appointment 
                  WHERE DoctorID=@docid AND CAST(AppointmentDate AS DATE)=@appDate", con);
                    cmd.Parameters.AddWithValue("@docid", doctorId);
                    cmd.Parameters.AddWithValue("@appDate", selectedDate);

                    int existingAppointments = (int)cmd.ExecuteScalar();

                    
                    SqlCommand cmd2 = new SqlCommand(
                        "SELECT AppointmentCapability FROM Doctor WHERE DoctorID=@docid", con);
                    cmd2.Parameters.AddWithValue("@docid", doctorId);

                    int capability = Convert.ToInt32(cmd2.ExecuteScalar());

                   
                    if (existingAppointments < capability)
                    {
                        txtColour.BackColor = Color.LightGreen;
                        txtColour.Text = "Available";
                    }
                    else
                    {
                        txtColour.BackColor = Color.LightCoral;
                        txtColour.Text = "Not Available";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking availability: " + ex.Message);
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (txtColour.Text != "Available")
            {
                MessageBox.Show("Doctor is not available. Please choose another date or doctor.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCost.Text))
            {
                MessageBox.Show("Please enter the appointment cost.");
                return;
            }

            if (!decimal.TryParse(txtCost.Text, out decimal cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid positive cost.");
                return;
            }

            string doctorId = cmbDoctor.SelectedValue.ToString();
            string patientId = cmbPatient.SelectedValue.ToString();
            DateTime selectedDate = dtpapp.Value.Date;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand insertCmd = new SqlCommand(
                        @"INSERT INTO Appointment (DoctorID, PatientID, AppointmentDate, Cost)
                  VALUES (@docid, @pid, @appDate, @cost)", con);

                    insertCmd.Parameters.AddWithValue("@docid", doctorId);
                    insertCmd.Parameters.AddWithValue("@pid", patientId);
                    insertCmd.Parameters.AddWithValue("@appDate", selectedDate);
                    
                    insertCmd.Parameters.AddWithValue("@cost", cost);

                    insertCmd.ExecuteNonQuery();

                    txtColour.BackColor = Color.LightGreen;
                    txtColour.Text = "Booked";

                    MessageBox.Show("✅ Appointment saved successfully with cost!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving appointment: " + ex.Message);
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                                A.AppointmentID,
                                D.DoctorID,
                                P.PatientID,
                                A.AppointmentDate,
                                A.Cost
                             FROM Appointment A
                             INNER JOIN Doctor D ON A.DoctorID = D.DoctorID
                             INNER JOIN Patient P ON A.PatientID = P.PatientID";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvgAppointment.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


