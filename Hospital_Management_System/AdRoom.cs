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
    public partial class AdRoom : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        public AdRoom()
        {
            InitializeComponent();
            dvgRoomManagment.Hide();
        }

        private void btnadroom_Click(object sender, EventArgs e)
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

        private void btnRoomShow_Click(object sender, EventArgs e)
        {
            dvgRoomManagment.Show();
            LoadRooms();
        }

        private void AdRoom_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void LoadRooms()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Room", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dvgRoomManagment.AutoGenerateColumns = true;
                    dvgRoomManagment.DataSource = dt;
                    dvgRoomManagment.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }
        }

        private void btnRoomsave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Room( RoomType, CostPerDay, RoomQuantity) VALUES(@type,@cost,@quantity)", con);
                  
                    cmd.Parameters.AddWithValue("@type", cmbAdRoomType.Text);
                    cmd.Parameters.AddWithValue("@cost", txtAdrmCost.Text);
                    cmd.Parameters.AddWithValue("@quantity", cmbadroomstatus.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Room saved successfully");
                    LoadRooms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message);
            }
        }

        private void btnRoomDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Room WHERE RoomID=@id", con);
                    cmd.Parameters.AddWithValue("@id", textadRoomId.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Room deleted successfully" : "⚠ No room found");
                    LoadRooms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting: " + ex.Message);
            }
        }

        private void btnRoomUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Room SET RoomType=@type,CostPerDay=@cost, RoomQuantity=@quantity WHERE RoomID=@id", con);
                    cmd.Parameters.AddWithValue("@id", textadRoomId.Text);
                    
                    cmd.Parameters.AddWithValue("@type", cmbAdRoomType.Text);
                    cmd.Parameters.AddWithValue("@cost", txtAdrmCost.Text);
                    cmd.Parameters.AddWithValue("@quantity", cmbadroomstatus.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "✅ Room updated successfully" : "⚠ No room found");
                    LoadRooms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating: " + ex.Message);
            }
        }

        private void btnrRmClear_Click(object sender, EventArgs e)
        {
            textadRoomId.Clear();
            
            cmbAdRoomType.SelectedIndex = -1;
            txtAdrmCost.Clear();
            cmbadroomstatus.SelectedIndex = -1;
        }

        private void btnrmSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT RoomID, RoomType,CostPerDayS, RoomQuantity FROM Room WHERE RoomID=@id", con);
                    da.SelectCommand.Parameters.AddWithValue("@id", textadRoomId.Text);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dvgRoomManagment.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("⚠ No room found");
                        dvgRoomManagment.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching: " + ex.Message);
                }
            }
        }

        private void dvgRoomManagment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgRoomManagment.Rows[e.RowIndex];

                textadRoomId.Text = row.Cells["RoomID"].Value.ToString();
                //txtAdRoomNo.Text = row.Cells["RoomNumber"].Value.ToString();
                cmbAdRoomType.Text = row.Cells["RoomType"].Value.ToString();
                txtAdrmCost.Text = row.Cells["CostPerDay"].Value.ToString();
                cmbadroomstatus.Text = row.Cells["RoomQuantity"].Value.ToString();
            }
        }
    }
}
