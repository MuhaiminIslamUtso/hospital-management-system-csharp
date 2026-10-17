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
    public partial class AdEmployee : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public AdEmployee()
        {
            InitializeComponent();
            
        }

        private void btnadEMBack_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form is AdHome homeForm)
                {
                    homeForm.Show();
                    this.Hide();

                   
                    if (homeForm.Controls["pnladdes"] is Panel pnl)
                    {
                        pnl.Visible = true;
                    }
                    return;
                }
            }
        }

        private void AdEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employee", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvgADEMP.AutoGenerateColumns = true;
                    dvgADEMP.DataSource = dt;

                    dvgADEMP.ScrollBars = ScrollBars.Both;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }
        private void LoadStaff()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employee", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvgADEMP.AutoGenerateColumns = true;
                    dvgADEMP.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message);
            }
        }



        private void btnstSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Employee
                        (EmployeeName, JoiningDate, Role, Age, Gender, Shift, Salary, ContactNumber) 
                        VALUES (@name, @dob, @qual, @age, @gender, @shift, @ach, @contact)", con);

                    cmd.Parameters.AddWithValue("@name", txtstStaffName.Text);
                    cmd.Parameters.AddWithValue("@dob", dptstDateofBath.Value);
                    cmd.Parameters.AddWithValue("@qual", cmbstQualification.Text);
                    cmd.Parameters.AddWithValue("@age", txtstAge.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbstGender.Text);
                    cmd.Parameters.AddWithValue("@shift", cmbStaffShift.Text);
                    cmd.Parameters.AddWithValue("@ach", txtstAchivementYear.Text);
                    cmd.Parameters.AddWithValue("@contact", txtstContactNumber.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Staff saved successfully");
                    LoadStaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving staff: " + ex.Message);
            }
        }

        private void btnemUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Employee
                        SET EmployeeName=@name, JoiningDate=@dob, Role=@qual, Age=@age, 
                            Gender=@gender, Shift=@shift, Salary=@ach, ContactNumber=@contact 
                        WHERE EmployeeId=@id", con);

                    cmd.Parameters.AddWithValue("@id", txtStaffId.Text);
                    cmd.Parameters.AddWithValue("@name", txtstStaffName.Text);
                    cmd.Parameters.AddWithValue("@dob", dptstDateofBath.Value);
                    cmd.Parameters.AddWithValue("@qual", cmbstQualification.Text);
                    cmd.Parameters.AddWithValue("@age", txtstAge.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbstGender.Text);
                    cmd.Parameters.AddWithValue("@shift", cmbStaffShift.Text);
                    cmd.Parameters.AddWithValue("@ach", txtstAchivementYear.Text);
                    cmd.Parameters.AddWithValue("@contact", txtstContactNumber.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Staff updated successfully" : "⚠ No staff found");
                    LoadStaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff: " + ex.Message);
            }
        }

        private void btnemDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE EmployeeId=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtStaffId.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Staff deleted successfully" : "⚠ No staff found");
                    LoadStaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting staff: " + ex.Message);
            }

        }

        private void btnemCLEAR_Click(object sender, EventArgs e)
        {
            txtStaffId.Clear();
            txtstStaffName.Clear();
            txtstAge.Clear();
            txtstAchivementYear.Clear();
            txtstContactNumber.Clear();
            cmbstQualification.SelectedIndex = -1;
            cmbstGender.SelectedIndex = -1;
            cmbStaffShift.SelectedIndex = -1;
            dptstDateofBath.Value = DateTime.Now;
        }

        private void btnemSEARCH_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employee WHERE EmployeeID = @id", con);
                    da.SelectCommand.Parameters.AddWithValue("@id", txtStaffId.Text);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dvgADEMP.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("⚠ No staff found");
                        dvgADEMP.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching staff: " + ex.Message);
                }
            }
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            LoadStaff();
            MessageBox.Show("🔄 Staff data refreshed");
        }

        private void dvgADEMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgADEMP.Rows[e.RowIndex];

                txtStaffId.Text = row.Cells["EmployeeID"].Value.ToString();
                txtstStaffName.Text = row.Cells["EmployeeName"].Value.ToString();
                dptstDateofBath.Value = Convert.ToDateTime(row.Cells["JoiningDate"].Value);
                cmbstQualification.Text = row.Cells["Role"].Value.ToString();
                txtstAge.Text = row.Cells["Age"].Value.ToString();
                cmbstGender.Text = row.Cells["Gender"].Value.ToString();
                cmbStaffShift.Text = row.Cells["Shift"].Value.ToString();
                txtstAchivementYear.Text = row.Cells["Salary"].Value.ToString();
                txtstContactNumber.Text = row.Cells["ContactNumber"].Value.ToString();
            }
        }

        private void cmbstGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
