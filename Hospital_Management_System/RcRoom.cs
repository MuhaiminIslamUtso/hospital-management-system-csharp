using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class RcRoom : Form
    {
        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        private RcRoomManagement rcRoomManagement = new RcRoomManagement();

        public RcRoom()
        {
            InitializeComponent();
            HookEvents();
            LoadPatients();
            LoadBookings();

        }

        private void HookEvents()
        {
            txtRoomID.TextChanged += InputFields_TextChanged;
            txtRoomNumber.TextChanged += InputFields_TextChanged;
            txtCostPerDay.TextChanged += InputFields_TextChanged;
            txtBookingDate.ValueChanged += (s, ev) => AutoCalculate();
            txtBookingDuration.TextChanged += InputFields_TextChanged;

            // 🔹 Auto-fill PatientID when name changes
            cmbone.SelectedIndexChanged += (s, e) =>
            {
                if (cmbone.SelectedValue != null && cmbone.SelectedValue is int)
                {
                    txtPatientID.Text = cmbone.SelectedValue.ToString();
                }
            };
        }
        private void LoadPatients()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT PatientID, PatientName FROM Patient";  // ✅ make sure table/columns match
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbone.DataSource = dt;
                    cmbone.DisplayMember = "PatientName";  // show patient name
                    cmbone.ValueMember = "PatientID";      // patient id hidden value
                    cmbone.SelectedIndex = -1;             // nothing selected initially
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Could not load patients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadBookings()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 🔹 Auto-update expired bookings
                    string updateQuery = "UPDATE Booking SET Status='Inactive' WHERE EndDate < CAST(GETDATE() AS date) AND Status='Active'";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.ExecuteNonQuery();
                    }

                    // 🔹 Load booking data with PatientName
                    string query = @"SELECT B.BookingID, P.PatientName, B.PatientID, B.RoomID, 
                                            B.StartDate, B.EndDate, B.CostPerDay, B.TotalCost, B.Status
                                     FROM Booking B
                                     INNER JOIN Patient P ON B.PatientID = P.PatientID";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvgPRBooking.DataSource = dt;  // Bind data to DataGridView
                    dvgPRBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Could not load bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AutoCalculate()
        {
            if (!decimal.TryParse(txtCostPerDay.Text, out decimal costPerDay) ||
                !int.TryParse(txtBookingDuration.Text, out int bookingDuration))
            {
                return;
            }

            var (totalCost, discount) = rcRoomManagement.CalculateTotalCost(costPerDay, bookingDuration);
            txtDiscount.Text = discount.ToString("0.##") + "%";
            txtrmTotalCost.Text = totalCost.ToString("0.##");
        }

        private void InputFields_TextChanged(object sender, EventArgs e)
        {
            AutoCalculate();
        }

        private void btnRCBACK_Click(object sender, EventArgs e)

        {
            RcHome h3 = new RcHome();
            h3.Show();
            this.Hide();
        }

        private void btnSearchAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbRoomType.Text))
                {
                    MessageBox.Show("Please select a room type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtDuration.Text, out int duration) || duration <= 0)
                {
                    MessageBox.Show("Please enter a valid duration (number of days).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string roomType = cmbRoomType.Text;
                DateTime startDate = dtpBooking.Value.Date;
                DateTime endDate = startDate.AddDays(duration - 1);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    List<int> roomIds = new List<int>();
                    using (SqlCommand cmd = new SqlCommand("SELECT RoomID FROM Room WHERE RoomType=@type", con))
                    {
                        cmd.Parameters.AddWithValue("@type", roomType);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                roomIds.Add(reader.GetInt32(0));
                            }
                        }
                    }

                    bool foundAvailable = false;

                    foreach (int roomId in roomIds)
                    {
                        using (SqlCommand cmd2 = new SqlCommand(
                            @"SELECT COUNT(*) FROM Booking
                              WHERE RoomID=@rid AND Status='Active'
                              AND (StartDate <= @endDate AND EndDate >= @startDate)", con))
                        {
                            cmd2.Parameters.AddWithValue("@rid", roomId);
                            cmd2.Parameters.AddWithValue("@startDate", startDate);
                            cmd2.Parameters.AddWithValue("@endDate", endDate);

                            int booked = (int)cmd2.ExecuteScalar();

                            if (booked == 0)
                            {
                                // ✅ Show availability
                                txtAvailability.Text = $"✅ Room {roomId} Available ({startDate:dd-MM-yyyy} to {endDate:dd-MM-yyyy})";
                                txtAvailability.BackColor = Color.LightGreen;

                                // ✅ Fill booking fields
                                txtRoomID.Text = roomId.ToString();
                                txtBookingDuration.Text = duration.ToString();
                                txtBookingDate.Value = startDate;

                                // ✅ Fetch CostPerDay
                                using (SqlCommand cmd3 = new SqlCommand("SELECT CostPerDay FROM Room WHERE RoomID=@rid", con))
                                {
                                    cmd3.Parameters.AddWithValue("@rid", roomId);
                                    object cost = cmd3.ExecuteScalar();
                                    if (cost != null)
                                        txtCostPerDay.Text = cost.ToString();
                                }

                                // ✅ Immediately recalc total cost & discount
                                AutoCalculate();

                                foundAvailable = true;
                                break;
                            }
                        }
                    }

                    if (!foundAvailable)
                    {
                        txtAvailability.Text = $"❌ No Rooms Available ({startDate:dd-MM-yyyy} to {endDate:dd-MM-yyyy})";
                        txtAvailability.BackColor = Color.LightCoral;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadBookings();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbone.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtRoomID.Text) ||
                    string.IsNullOrWhiteSpace(txtBookingDuration.Text) ||
                    string.IsNullOrWhiteSpace(txtCostPerDay.Text))
                {
                    MessageBox.Show("⚠️ Please select a patient and fill in all booking details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int patientId = (int)cmbone.SelectedValue;   // Auto from ComboBox
                txtPatientID.Text = patientId.ToString();   // Auto-fill PatientID textbox

                int roomId = int.Parse(txtRoomID.Text);
                int duration = int.Parse(txtBookingDuration.Text);

                DateTime startDate = txtBookingDate.Value.Date;
                DateTime endDate = startDate.AddDays(duration - 1);

                decimal costPerDay = decimal.Parse(txtCostPerDay.Text);
                decimal totalCost = decimal.Parse(txtrmTotalCost.Text);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Double booking prevention
                    string checkQuery = @"SELECT COUNT(*) FROM Booking
                                  WHERE RoomID=@rid AND Status='Active'
                                  AND (StartDate <= @edate AND EndDate >= @sdate)";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@rid", roomId);
                        checkCmd.Parameters.AddWithValue("@sdate", startDate);
                        checkCmd.Parameters.AddWithValue("@edate", endDate);

                        int alreadyBooked = (int)checkCmd.ExecuteScalar();
                        if (alreadyBooked > 0)
                        {
                            MessageBox.Show("❌ This room was just booked by another patient. Try again.",
                                "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert booking
                    string query = @"INSERT INTO Booking 
                             (PatientID, RoomID, StartDate, EndDate, CostPerDay, TotalCost, Status) 
                             VALUES (@pid, @rid, @sdate, @edate, @costPerDay, @totalCost, 'Active')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@pid", patientId);
                        cmd.Parameters.AddWithValue("@rid", roomId);
                        cmd.Parameters.AddWithValue("@sdate", startDate);
                        cmd.Parameters.AddWithValue("@edate", endDate);
                        cmd.Parameters.AddWithValue("@costPerDay", costPerDay);
                        cmd.Parameters.AddWithValue("@totalCost", totalCost);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("✅ Room booked successfully! Status: Active", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error while booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {
            if (cmbone.SelectedValue != null && cmbone.SelectedValue is int)
            {
                txtPatientID.Text = cmbone.SelectedValue.ToString();
            }
        }

       
    }


    public class RcRoomManagement
    {
        public (decimal TotalCost, decimal Discount) CalculateTotalCost(decimal costPerDay, int bookingDuration)
        {
            decimal totalCost = costPerDay * bookingDuration;
            decimal discount = 0;

            if (bookingDuration > 30) { discount = 18; totalCost *= 0.82m; }
            else if (bookingDuration > 15) { discount = 9.5m; totalCost *= 0.905m; }
            else if (bookingDuration > 10) { discount = 4; totalCost *= 0.96m; }
            else if (bookingDuration > 3) { discount = 2; totalCost *= 0.98m; }

            return (totalCost, discount);
        }


    }

}

       

    





