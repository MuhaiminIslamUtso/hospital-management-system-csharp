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
    public partial class AdTest : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public AdTest()
        {
            InitializeComponent();
            btntShowDetails.Hide();
        }

        private void btntestBACK_Click(object sender, EventArgs e)
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

        private void AdTest_Load(object sender, EventArgs e)
        {
            LoadTests();
        }
        private void LoadTests()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT TestID, TestName, TestCost FROM Test", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvgtestmanag.AutoGenerateColumns = true;
                    dvgtestmanag.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tests: " + ex.Message);
            }
        }

        private void btntestSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Test(TestName, TestCost) VALUES(@name, @cost)", con);
                    cmd.Parameters.AddWithValue("@name", txtNewTest.Text);
                    cmd.Parameters.AddWithValue("@cost", txtTestCost.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Test saved successfully");
                    LoadTests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message);
            }
        }

        private void btntestUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Test SET TestName=@name, TestCost=@cost WHERE TestID=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtTestID.Text);
                    cmd.Parameters.AddWithValue("@name", txtNewTest.Text);
                    cmd.Parameters.AddWithValue("@cost", txtTestCost.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Test updated successfully" : "⚠ No test found");
                    LoadTests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating: " + ex.Message);
            }
        }

        private void btntdelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Test WHERE TestID=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtTestID.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Test deleted successfully" : "⚠ No test found");
                    LoadTests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting: " + ex.Message);
            }
        }

        private void btntClear_Click(object sender, EventArgs e)
        {
            txtTestID.Clear();
            txtNewTest.Clear();
            txtTestCost.Clear();
        }

        private void btnTsearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT TestID, TestName, TestCost FROM Test WHERE TestID=@id", con);
                    da.SelectCommand.Parameters.AddWithValue("@id", txtTestID.Text);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dvgtestmanag.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("⚠ No test found");
                        dvgtestmanag.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching: " + ex.Message);
                }
            }
        }

        private void dvgtestmanag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgtestmanag.Rows[e.RowIndex];

                txtTestID.Text = row.Cells["TestID"].Value.ToString();
                txtNewTest.Text = row.Cells["TestName"].Value.ToString();
                txtTestCost.Text = row.Cells["TestCost"].Value.ToString();
            }
        }

        private void btntShowDetails_Click(object sender, EventArgs e)
        {
            btntShowDetails.Show();
            LoadTests();
        }
    }
}

