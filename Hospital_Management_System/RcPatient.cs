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
    public partial class RcPatient : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public RcPatient()
        {
            InitializeComponent();
            dvgpatientManagment.Hide();
        }



        private void btnBackAddPatient_Click(object sender, EventArgs e)
        {
            RcHome h2 = new RcHome();
            h2.Show();
            this.Hide();
        }

       

        private void RcPatient_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Patient", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvgpatientManagment.AutoGenerateColumns = true;
                    dvgpatientManagment.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }

        private void btnpmSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Patient( PatientName, Age, BloodGroup, Gender, Address, MajorDeases, ContactNo, Email) " +
                        "VALUES( @name, @age, @blood, @gender, @address, @disease, @contact, @email)", con);

                    //cmd.Parameters.AddWithValue("@id", txtPatientId.Text);
                    cmd.Parameters.AddWithValue("@name", txtPatientName.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@blood", cmbBloodGroup.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbadnpGender.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@disease", cmbMajorDeases.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@email", txtpmEmail.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Patient saved successfully");
                    LoadPatients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving patient: " + ex.Message);
            }
        }

        private void btnpmUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Patient SET PatientName=@name, Age=@age, BloodGroup=@blood, Gender=@gender, " +
                        "Address=@address, MajorDeases=@disease, ContactNo=@contact, Email=@email WHERE PatientId=@id", con);

                    cmd.Parameters.AddWithValue("@id", txtPatientId.Text);
                    cmd.Parameters.AddWithValue("@name", txtPatientName.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@blood", cmbBloodGroup.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbadnpGender.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@disease", cmbMajorDeases.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@email", txtpmEmail.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Patient updated successfully" : "⚠ No patient found");
                    LoadPatients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message);
            }
        }

        private void btnpmDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPatientId.Text))
            {
                MessageBox.Show("⚠ Enter Patient ID to delete");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Patient WHERE PatientId=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtPatientId.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Patient deleted successfully" : "⚠ No patient found");

                    LoadPatients();
                    btnpmClear.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting patient: " + ex.Message);
            }
        }

        private void btnpmSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Patient WHERE PatientId=@id", con);
                    da.SelectCommand.Parameters.AddWithValue("@id", txtPatientId.Text);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dvgpatientManagment.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("⚠ No patient found");
                        dvgpatientManagment.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching patient: " + ex.Message);
                }
            }
        }

        private void btnpmRefersh_Click(object sender, EventArgs e)
        {

            LoadPatients();
            MessageBox.Show("🔄 Data refreshed successfully");
        }

        private void btnpmShowDetails_Click(object sender, EventArgs e)
        {
            dvgpatientManagment.Show();
        }

        private void btnpmClear_Click(object sender, EventArgs e)
        {
            txtPatientId.Clear();
            txtPatientName.Clear();
            txtAge.Clear();
            cmbBloodGroup.SelectedIndex = -1;
            cmbadnpGender.SelectedIndex = -1;
            txtAddress.Clear();
            cmbMajorDeases.SelectedIndex = -1;
            txtContactNo.Clear();
            txtpmEmail.Clear();

        }

        private void dvgpatientManagment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgpatientManagment.Rows[e.RowIndex];
                txtPatientId.Text = row.Cells["PatientId"].Value.ToString();
                txtPatientName.Text = row.Cells["PatientName"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                cmbBloodGroup.Text = row.Cells["BloodGroup"].Value.ToString();
                cmbadnpGender.Text = row.Cells["Gender"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                cmbMajorDeases.Text = row.Cells["MajorDeases"].Value.ToString();
                txtContactNo.Text = row.Cells["ContactNo"].Value.ToString();
                txtpmEmail.Text = row.Cells["Email"].Value.ToString();
            } 
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtPatientName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("⚠ Please fill all required fields (Name, Age, Contact No).");
                return false;
            }

            if (!int.TryParse(txtAge.Text, out _))
            {
                MessageBox.Show("❌ Age must be a number");
                return false;
            }

            if (!long.TryParse(txtContactNo.Text, out _))
            {
                MessageBox.Show("❌ Contact number must be numeric");
                return false;
            }

            return true;
        }

    }
}
