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
    public partial class User : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public User()
        {
            InitializeComponent();
            dgvUsers.Hide();
        }
      
        private void btnucBACK_Click(object sender, EventArgs e)
        {
            AdHome newHome = new AdHome();
            newHome.Show();
            this.Hide();

        }

    private void User_Load(object sender, EventArgs e)
        {
            
            LoadUsers();

        }
        private void LoadUsers()
        {
         
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT UserID, UserType, Password, UserNo FROM Admin", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvUsers.AutoGenerateColumns = true; // important
                    dgvUsers.DataSource = dt;

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        

        private void btnuserSave_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Admin(UserID, UserType, Password, UserNo) VALUES(@id,@type,@pass,@no)", con);
                    cmd.Parameters.AddWithValue("@id", txtUserID.Text);
                    cmd.Parameters.AddWithValue("@type", cmbUserType.Text);
                    cmd.Parameters.AddWithValue("@pass", txtucPassword.Text);
                    cmd.Parameters.AddWithValue("@no", txtUserSl.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ User saved successfully");
                    LoadUsers();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" Database error while saving: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error: " + ex.Message);
            }
        }

        private void btnuserUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Admin SET UserType=@type, Password=@pass, UserNo=@no WHERE UserID=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtUserID.Text);
                    cmd.Parameters.AddWithValue("@type", cmbUserType.Text);
                    cmd.Parameters.AddWithValue("@pass", txtucPassword.Text);
                    cmd.Parameters.AddWithValue("@no", txtUserSl.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ User updated successfully" : "⚠ No user found");
                    LoadUsers();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" Database error while updating: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error: " + ex.Message);
            }
        }

        private void btnuserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Admin WHERE UserID=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtUserID.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ User deleted successfully" : "⚠ No user found");
                    LoadUsers();
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

        private void btnuucSERCH_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT UserID, UserType, Password, UserNo FROM Admin WHERE UserID = @id", con);
                    da.SelectCommand.Parameters.AddWithValue("@id", txtseucUSERID.Text);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvUsers.DataSource = dt; // show only matching row(s)
                    }
                    else
                    {
                        MessageBox.Show("No user found");
                        dgvUsers.DataSource = null; // clear grid if nothing found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching user: " + ex.Message);
                }
            }
        }




        private void btnUcClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            cmbUserType.SelectedIndex = -1;
            txtucPassword.Clear();
            txtUserSl.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();  // 🔄 Refresh DataGridView
            MessageBox.Show("Data refreshed successfully");
        }

        private void btnUcShowDetails_Click(object sender, EventArgs e)
        {
            dgvUsers.Show();
           
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure not clicking header
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                cmbUserType.Text = row.Cells["UserType"].Value.ToString();
                txtucPassword.Text = row.Cells["Password"].Value.ToString();
                txtUserSl.Text = row.Cells["UserNo"].Value.ToString();
            }
        }
    }
}
