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
  

    public partial class ADNurse : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        private object txtDcLicenceID;

        public ADNurse()
        {
            InitializeComponent();
            dgvaddNurse.Hide();

        }



        private void btnnsBACK_Click_1(object sender, EventArgs e)
        {
            
            foreach (Form form in Application.OpenForms)
            {
                if (form is AdHome homeForm)
                {
                    homeForm.Show();
                    this.Hide(); // Hide AdNurse form

                    // Ensure pnladdes is visible in AdHome
                    if (homeForm.Controls["pnladdes"] is Panel pnl)
                    {
                        pnl.Visible = true;
                    }
                    return;
                }
            }


        }

        private void ADNurse_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nurse", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvaddNurse.AutoGenerateColumns = true;
                    dgvaddNurse.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading nurses: " + ex.Message);
            }

        }
        private void GenerateNurseLicenseID()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT ISNULL(MAX(CAST(LicenseID as int)), 999) + 1 FROM Nurse", con);

                    int newId = (int)cmd.ExecuteScalar();
                    txtnsLicenseId.Text = newId.ToString("D4");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Nurse License ID: " + ex.Message);
            }
        }

        private void LoadNurses()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nurse", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvaddNurse.AutoGenerateColumns = true;
                    dgvaddNurse.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading nurses: " + ex.Message);
            }
        }

        private void btnnsSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Nurse(Name, JoningDate, LicenseID, Age, Gender, Salary, Shift, ContactNumber) " +
                        "VALUES(@name, @jdate, @lic, @age, @gender, @salary, @shift, @contact)", con);

                    cmd.Parameters.AddWithValue("@name", txtnrName.Text);
                    cmd.Parameters.AddWithValue("@jdate", dtpadNurse.Value);
                    cmd.Parameters.AddWithValue("@lic", txtnsLicenseId.Text);
                    cmd.Parameters.AddWithValue("@age", int.TryParse(txtnrAge.Text, out int ageVal) ? ageVal : 0);
                    cmd.Parameters.AddWithValue("@gender", cmbnsasGender.Text);
                    cmd.Parameters.AddWithValue("@salary", decimal.TryParse(txtnusal.Text, out decimal salVal) ? salVal : 0);
                    cmd.Parameters.AddWithValue("@shift", cmbNsSshift.Text);
                    cmd.Parameters.AddWithValue("@contact", txtnsContactNumber.Text);
                   

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Nurse saved successfully");

                    LoadNurses();
                    GenerateNurseLicenseID();
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

        private void btnNUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Nurse SET Name=@name, JoningDate=@jdate, LicenseID=@lic, Age=@age, Gender=@gender, Salary=@salary, Shift=@shift, ContactNumber=@contact " +
                        "WHERE NurseID=@nid", con);

                    cmd.Parameters.AddWithValue("@name", txtnrName.Text);
                    cmd.Parameters.AddWithValue("@jdate", dtpadNurse.Value);
                    cmd.Parameters.AddWithValue("@lic", txtnsLicenseId.Text);
                    cmd.Parameters.AddWithValue("@age", int.TryParse(txtnrAge.Text, out int ageVal) ? ageVal : 0);
                    cmd.Parameters.AddWithValue("@gender", cmbnsasGender.Text);
                    cmd.Parameters.AddWithValue("@salary", decimal.TryParse(txtnusal.Text, out decimal salVal) ? salVal : 0);
                    cmd.Parameters.AddWithValue("@shift", cmbNsSshift.Text);
                    cmd.Parameters.AddWithValue("@contact", txtnsContactNumber.Text);
                    cmd.Parameters.AddWithValue("@nid", txtNSNurseId.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Nurse updated successfully" : "⚠ No nurse found");

                    LoadNurses();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Nurse WHERE NurseID=@nid", con);
                    cmd.Parameters.AddWithValue("@nid", txtNSNurseId.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Nurse deleted successfully" : "⚠ No nurse found");

                    LoadNurses();
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

        private void btnNClear_Click(object sender, EventArgs e)
        {
            {
                txtNSNurseId.Clear();
                txtnrName.Clear();
                txtnsLicenseId.Clear();
                txtnrAge.Clear();
                txtnusal.Clear();
                txtnsContactNumber.Clear();
                cmbnsasGender.SelectedIndex = -1;
                cmbNsSshift.SelectedIndex = -1;
                dtpadNurse.Value = DateTime.Now;

                GenerateNurseLicenseID();
            }
        }

        private void dgvaddNurse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvaddNurse.Rows[e.RowIndex];

                txtNSNurseId.Text = row.Cells["NurseID"].Value?.ToString() ?? "";
                txtnrName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                dtpadNurse.Value = DateTime.TryParse(row.Cells["JoningDate"].Value?.ToString(), out DateTime dtVal) ? dtVal : DateTime.Now;
                txtnsLicenseId.Text = row.Cells["LicenseID"].Value?.ToString() ?? "";
                txtnrAge.Text = row.Cells["Age"].Value?.ToString() ?? "";
                cmbnsasGender.Text = row.Cells["Gender"].Value?.ToString() ?? "";
                txtnusal.Text = row.Cells["Salary"].Value?.ToString() ?? "";
                cmbNsSshift.Text = row.Cells["Shift"].Value?.ToString() ?? "";
                txtnsContactNumber.Text = row.Cells["ContactNumber"].Value?.ToString() ?? "";
            }
        }

        private void BtnNshowDetails_Click(object sender, EventArgs e)
        {
            dgvaddNurse.Show();
            LoadNurses();
        }

        private void btnNSreach_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT * FROM Nurse 
                                     WHERE Name LIKE @search 
                                        OR NurseID LIKE @search 
                                        OR LicenseID LIKE @search 
                                        OR ContactNumber LIKE @search";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@search", "%" + txtNSNurseId.Text.Trim() + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvaddNurse.AutoGenerateColumns = true;
                    dgvaddNurse.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("⚠ No matching nurse found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }

        private void txtnsLicenseId_TextChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(1000, 10000);
            txtnsLicenseId.Text = id.ToString();
        }
    }
    }

    


