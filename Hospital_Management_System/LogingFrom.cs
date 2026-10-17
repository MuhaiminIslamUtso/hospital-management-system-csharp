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
    public partial class LogingFrom : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public LogingFrom()
        {
            InitializeComponent();
        }

    
        private void btnClear_Click(object sender, EventArgs e) 
        {
            txtUserId.Text = string.Empty;
            txtpassword.Text = string.Empty;
        }

        private void btnLoging_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Please enter both User ID and Password.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT UserType FROM Admin WHERE UserId=@id AND Password=@pass", con);
                    cmd.Parameters.AddWithValue("@id", txtUserId.Text);
                    cmd.Parameters.AddWithValue("@pass", txtpassword.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string userType = result.ToString();

                        if (userType == "Admin")
                        {
                            MessageBox.Show("Login successful as Admin");
                            AdHome hm = new AdHome();
                            hm.Show();
                            this.Hide();
                        }
                        else if (userType == "Receptionist")
                        {
                            MessageBox.Show("Login successful as Receptionist");
                            RcHome rm = new RcHome();
                            rm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid User ID or Password.");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred: " + exc.Message);
            }
        }

       

        private void btnChatBot_Click(object sender, EventArgs e)
        {
            Chatbot b = new Chatbot();
            b.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LogingFrom_Load(object sender, EventArgs e)
        {

        }
    }
}

