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
using System.Globalization;
using System.Net.Mail;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace Hospital_Management_System
{
    public partial class Chatbot : Form
    {

        private string connectionString = "Data Source=DESKTOP-U9K8HEV\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        private Action<string> currentHandler;
        private Dictionary<string, object> sessionData = new Dictionary<string, object>();
        public Chatbot()
        {
            InitializeComponent();
            Start();
        }

        public void Start()
        {
            AppendBotMessage("🤖 Welcome to Hospital ChatBot!");
            AppendBotMessage("Quick Options: [1] Patient Admission, [2] Appointment, [3] Test Order, [4] Room Booking, [5] Patient Login");
            currentHandler = MainMenu;
        }

        private void AppendBotMessage(string msg)
        {
            txtChatBot.AppendText("Bot: " + msg + Environment.NewLine);
            txtChatBot.ScrollToCaret();
        }
      

        public void HandleInput(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                txtChatBot.AppendText("You: " + input + Environment.NewLine);
                currentHandler?.Invoke(input.Trim());
            }
        }
        private void MainMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    sessionData.Clear();
                    AppendBotMessage("Enter Patient Name:");
                    currentHandler = HandleAdmission_Name;
                    break;

                case "2":
                    if (!sessionData.ContainsKey("PatientID"))
                    {
                        AppendBotMessage("⚠️ Please admit or login patient first!");
                        Start(); return;
                    }
                    ShowDoctors();
                    break;

                case "3":
                    if (!sessionData.ContainsKey("PatientID"))
                    {
                        AppendBotMessage("⚠️ Please admit or login patient first!");
                        Start(); return;
                    }
                    ShowTests();
                    break;

                case "4":
                    if (!sessionData.ContainsKey("PatientID"))
                    {
                        AppendBotMessage("⚠️ Please admit or login patient first!");
                        Start(); return;
                    }
                    ShowRooms();
                    break;

                case "5":
                    AppendBotMessage("Enter Patient ID to login:");
                    currentHandler = LoadPatientByID;
                    break;

                default:
                    AppendBotMessage("Invalid choice. Options: 1,2,3,4,5");
                    break;
            }
        }
        private void LoadPatientByID(string pidInput)
        {
            if (!int.TryParse(pidInput, out int pid))
            {
                AppendBotMessage("Invalid Patient ID. Enter again:");
                return;
            }

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand("SELECT * FROM Patient WHERE PatientID=@PID", con);
                    cmd.Parameters.AddWithValue("@PID", pid);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sessionData.Clear();
                            sessionData["PatientID"] = pid;
                            sessionData["PatientName"] = reader["PatientName"].ToString();
                            AppendBotMessage($"✅ Welcome back {sessionData["PatientName"]}! You are now logged in.");
                            Start();
                        }
                        else
                        {
                            AppendBotMessage("❌ Patient not found. Please admit first.");
                            Start();
                        }
                    }
                }
            }
            catch (Exception ex) { AppendBotMessage("Error: " + ex.Message); }
        }
        private void HandleAdmission_Name(string name)
        {
            sessionData["PatientName"] = name;
            AppendBotMessage("Enter Age (in years):");
            currentHandler = HandleAdmission_Age;
        }

        private void HandleAdmission_Age(string ageInput)
        {
            if (!int.TryParse(ageInput, out int age) || age <= 0)
            {
                AppendBotMessage("Invalid age. Enter a positive number:");
                return;
            }
            sessionData["Age"] = age;
            AppendBotMessage("Enter Gender (Male/Female):");
            currentHandler = HandleAdmission_Gender;
        }

        private void HandleAdmission_Gender(string gender)
        {
            gender = gender.Trim().ToLower();
            if (gender != "male" && gender != "female")
            {
                AppendBotMessage("Invalid gender. Enter Male or Female:");
                return;
            }
            sessionData["Gender"] = gender;
            AppendBotMessage("Enter Blood Group (A+, A-, B+, B-, O+, O-, AB+, AB-):");
            currentHandler = HandleAdmission_BloodGroup;
        }
        private void HandleAdmission_BloodGroup(string bg)
        {
            string[] valid = { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" };
            if (Array.IndexOf(valid, bg.ToUpper()) < 0)
            {
                AppendBotMessage("Invalid Blood Group. Enter again:");
                return;
            }
            sessionData["BloodGroup"] = bg.ToUpper();
            AppendBotMessage("Enter Address:");
            currentHandler = HandleAdmission_Address;
        }

        private void HandleAdmission_Address(string addr)
        {
            sessionData["Address"] = addr;
            AppendBotMessage("Enter Major Diseases (or 'None'):");
            currentHandler = HandleAdmission_MajorDiseases;
        }

        private void HandleAdmission_MajorDiseases(string diseases)
        {
            sessionData["MajorDeases"] = diseases;
            AppendBotMessage("Enter Contact Number (digits only):");
            currentHandler = HandleAdmission_Contact;
        }

        private void HandleAdmission_Contact(string contact)
        {
            if (!long.TryParse(contact, out long cnum))
            {
                AppendBotMessage("Invalid contact. Enter digits only:");
                return;
            }
            sessionData["ContactNo"] = cnum;
            AppendBotMessage("Enter Email:");
            currentHandler = HandleAdmission_Email;
        }
        private void HandleAdmission_Email(string email)
        {
            sessionData["Email"] = email;

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand(@"
                        INSERT INTO Patient (PatientName, Age, Gender, BloodGroup, Address, MajorDeases, ContactNo, Email)
                        VALUES (@Name,@Age,@Gender,@BG,@Addr,@Diseases,@Contact,@Email);
                        SELECT SCOPE_IDENTITY();", con);
                    cmd.Parameters.AddWithValue("@Name", sessionData["PatientName"]);
                    cmd.Parameters.AddWithValue("@Age", sessionData["Age"]);
                    cmd.Parameters.AddWithValue("@Gender", sessionData["Gender"]);
                    cmd.Parameters.AddWithValue("@BG", sessionData["BloodGroup"]);
                    cmd.Parameters.AddWithValue("@Addr", sessionData["Address"]);
                    cmd.Parameters.AddWithValue("@Diseases", sessionData["MajorDeases"]);
                    cmd.Parameters.AddWithValue("@Contact", sessionData["ContactNo"]);
                    cmd.Parameters.AddWithValue("@Email", sessionData["Email"]);

                    sessionData["PatientID"] = Convert.ToInt32(cmd.ExecuteScalar());
                }
                AppendBotMessage($"✅ Patient admitted. PatientID = {sessionData["PatientID"]}");
            }
            catch (Exception ex) { AppendBotMessage("Error saving patient: " + ex.Message); }

            Start();
        }
        private void ShowDoctors()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand("SELECT DoctorID, Name, Specialization, WorkingTime, AppointmentCapability FROM Doctor", con);
                    using (var reader = cmd.ExecuteReader())
                    {
                        sb.AppendLine("Available Doctors:");
                        while (reader.Read())
                            sb.AppendLine($"ID:{reader["DoctorID"]} {reader["Name"]} ({reader["Specialization"]}) Time:{reader["WorkingTime"]} MaxPatients:{reader["AppointmentCapability"]}");
                    }
                }
            }
            catch (Exception ex) { sb.AppendLine("Error: " + ex.Message); }

            AppendBotMessage(sb.ToString());
            AppendBotMessage("Enter Doctor ID to book appointment:");
            currentHandler = HandleAppointment_Doctor;
        }


        private void HandleAppointment_Doctor(string input)
        {
            if (!int.TryParse(input, out int docID)) { AppendBotMessage("Invalid ID. Enter again:"); return; }
            sessionData["DoctorID"] = docID;

            AppendBotMessage("Enter Appointment Date (dd-MM-yyyy):");
            currentHandler = HandleAppointment_Date;
        }

        private void HandleAppointment_Date(string date)
        {
            if (!DateTime.TryParseExact(date, "dd-MM-yyyy", null, DateTimeStyles.None, out DateTime dt))
            {
                AppendBotMessage("Invalid date. Enter dd-MM-yyyy:");
                return;
            }
            sessionData["AppointmentDate"] = dt;

            int bookedCount = 0;
            int capability = 0;
            string workingTime = "";

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Get Doctor capability and working time
                    var cmdDoc = new SqlCommand("SELECT AppointmentCapability, WorkingTime FROM Doctor WHERE DoctorID=@ID", con);
                    cmdDoc.Parameters.AddWithValue("@ID", sessionData["DoctorID"]);
                    using (var reader = cmdDoc.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            capability = Convert.ToInt32(reader["AppointmentCapability"]);
                            workingTime = reader["WorkingTime"].ToString();
                        }
                    }

                    // Count already booked patients for that doctor & date
                    var cmdCount = new SqlCommand("SELECT COUNT(*) FROM Appointment WHERE DoctorID=@ID AND CAST(AppointmentDate AS DATE)=@Date", con);
                    cmdCount.Parameters.AddWithValue("@ID", sessionData["DoctorID"]);
                    cmdCount.Parameters.AddWithValue("@Date", dt.Date);
                    bookedCount = Convert.ToInt32(cmdCount.ExecuteScalar());
                }
            }
            catch (Exception ex) { AppendBotMessage("Error: " + ex.Message); return; }

            if (bookedCount >= capability)
            {
                AppendBotMessage($"❌ Doctor is fully booked on {dt:dd-MM-yyyy} at {workingTime}. Choose another date.");
                return;
            }

            sessionData["WorkingTime"] = workingTime;

            AppendBotMessage($"Cost: 1000 TK\nDoctor available at {workingTime} on {dt:dd-MM-yyyy}.");
            AppendBotMessage("Type 'Y' to confirm or 'N' to cancel:");
            currentHandler = HandleAppointment_Confirm;
        }

        private void HandleAppointment_Confirm(string input)
        {
            if (input.ToLower() != "y")
            {
                AppendBotMessage("Appointment cancelled.");
                Start();
                return;
            }

            try
            {
                int appointmentID = 0;
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand(@"
                INSERT INTO Appointment (PatientID, DoctorID, AppointmentDate, Cost)
                VALUES (@PID, @DID, @Date, 1000);
                SELECT SCOPE_IDENTITY();", con);
                    cmd.Parameters.AddWithValue("@PID", sessionData["PatientID"]);
                    cmd.Parameters.AddWithValue("@DID", sessionData["DoctorID"]);
                    DateTime fullDateTime = ((DateTime)sessionData["AppointmentDate"]).Date;
                    cmd.Parameters.AddWithValue("@Date", fullDateTime);
                    appointmentID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                AppendBotMessage($"✅ Appointment booked successfully!");
                AppendBotMessage($"Appointment ID: {appointmentID}");
                AppendBotMessage($"Date: {((DateTime)sessionData["AppointmentDate"]).ToString("dd-MM-yyyy")}");
                AppendBotMessage($"Time: {sessionData["WorkingTime"]}");
                AppendBotMessage("Cost: 1000 TK");
            }
            catch (Exception ex) { AppendBotMessage("Error: " + ex.Message); }

            Start();
        }


        // -------------------- TEST ORDER --------------------
        private void ShowTests()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand("SELECT TestName, TestCost FROM Test", con);
                    using (var reader = cmd.ExecuteReader())
                    {
                        sb.AppendLine("Available Tests:");
                        while (reader.Read())
                            sb.AppendLine($"{reader["TestName"]} - {reader["TestCost"]} TK");
                    }
                }
            }
            catch (Exception ex) { sb.AppendLine("Error: " + ex.Message); }

            AppendBotMessage(sb.ToString());
            AppendBotMessage("Enter test names separated by comma (e.g., Blood Test,X-Ray,ECG):");
            currentHandler = HandleTest_SelectMultiple;
        }


        private void HandleTest_SelectMultiple(string input)
        {
            string[] tests = input.Split(',').Select(t => t.Trim()).Where(t => t != "").ToArray();
            if (tests.Length == 0)
            {
                AppendBotMessage("No test selected. Enter again:");
                return;
            }

            List<string> validTests = new List<string>();
            decimal totalCost = 0;

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    foreach (var test in tests)
                    {
                        var cmd = new SqlCommand("SELECT TestCost FROM Test WHERE TestName=@TestName", con);
                        cmd.Parameters.AddWithValue("@TestName", test);
                        object cost = cmd.ExecuteScalar();
                        if (cost != null)
                        {
                            validTests.Add(test);
                            totalCost += Convert.ToDecimal(cost);
                        }
                    }
                }
            }
            catch (Exception ex) { AppendBotMessage("Error: " + ex.Message); return; }

            if (validTests.Count == 0)
            {
                AppendBotMessage("No valid tests selected. Enter again:");
                return;
            }

            sessionData["TestNames"] = validTests;
            sessionData["TestTotalCost"] = totalCost;

            AppendBotMessage($"Selected Tests: {string.Join(", ", validTests)}");
            AppendBotMessage($"Total Cost: {totalCost} TK\nType 'confirm' to order or 'cancel' to abort:");
            currentHandler = HandleTest_ConfirmMultiple;
        }


        private void HandleTest_ConfirmMultiple(string input)
        {
            if (input.ToLower() != "confirm")
            {
                AppendBotMessage("Test order cancelled.");
                Start();
                return;
            }

            try
            {
                int orderID = 0;
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();

                    var cmd = new SqlCommand(@"
                INSERT INTO TestOrder (PatientID, PatientName, TestNames, TotalCost, Status)
                VALUES (@PID, @Name, @Tests, @Cost, 'Unpaid');
                SELECT SCOPE_IDENTITY();", con);

                    cmd.Parameters.AddWithValue("@PID", sessionData["PatientID"]);
                    cmd.Parameters.AddWithValue("@Name", sessionData["PatientName"]);
                    cmd.Parameters.AddWithValue("@Tests", string.Join(", ", (List<string>)sessionData["TestNames"]));
                    cmd.Parameters.AddWithValue("@Cost", sessionData["TestTotalCost"]);

                    orderID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                AppendBotMessage($"✅ Test order created successfully!");
                AppendBotMessage($"Order ID: {orderID}");
                AppendBotMessage($"Total Cost: {sessionData["TestTotalCost"]} TK");
                AppendBotMessage("💳 Please pay to get your Serial Number.");
            }
            catch (Exception ex)
            {
                AppendBotMessage("Error: " + ex.Message);
            }

            Start();
        }



        // -------------------- ROOM BOOKING --------------------
        private void ShowRooms()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand("SELECT RoomID, RoomType, CostPerDay, RoomQuantity FROM Room", con);
                    using (var reader = cmd.ExecuteReader())
                    {
                        sb.AppendLine("Available Rooms:");
                        while (reader.Read())
                            sb.AppendLine($"ID:{reader["RoomID"]} {reader["RoomType"]} Cost:{reader["CostPerDay"]} TK Qty:{reader["RoomQuantity"]}");
                    }
                }
            }
            catch (Exception ex) { sb.AppendLine("Error: " + ex.Message); }

            AppendBotMessage(sb.ToString());
            AppendBotMessage("Enter Room ID:");
            currentHandler = HandleRoom_Select;
        }

        private void HandleRoom_Select(string input)
        {
            if (!int.TryParse(input, out int rid)) { AppendBotMessage("Invalid ID. Enter again:"); return; }
            sessionData["RoomID"] = rid;
            AppendBotMessage("Enter Start Date (dd-MM-yyyy):");
            currentHandler = HandleRoom_StartDate;
        }

        private void HandleRoom_StartDate(string start)
        {
            if (!DateTime.TryParseExact(start, "dd-MM-yyyy", null, DateTimeStyles.None, out DateTime dt))
            {
                AppendBotMessage("Invalid date. Enter dd-MM-yyyy:");
                return;
            }
            sessionData["StartDate"] = dt;
            AppendBotMessage("Enter number of days:");
            currentHandler = HandleRoom_Duration;
        }

        private void HandleRoom_Duration(string days)
        {
            if (!int.TryParse(days, out int d) || d <= 0) { AppendBotMessage("Invalid number. Enter again:"); return; }
            sessionData["Duration"] = d;

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Get room cost and quantity
                    var cmdRoom = new SqlCommand("SELECT CostPerDay, RoomQuantity FROM Room WHERE RoomID=@RoomID", con);
                    cmdRoom.Parameters.AddWithValue("@RoomID", sessionData["RoomID"]);
                    using (var reader = cmdRoom.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sessionData["CostPerDay"] = Convert.ToDecimal(reader["CostPerDay"]);
                            sessionData["RoomQuantity"] = Convert.ToInt32(reader["RoomQuantity"]);
                        }
                    }

                    DateTime start = (DateTime)sessionData["StartDate"];
                    DateTime end = start.AddDays(d - 1);

                    // Auto update expired bookings to Inactive
                    var cmdUpdate = new SqlCommand("UPDATE Booking SET Status='Inactive' WHERE Status='Active' AND EndDate < CAST(GETDATE() AS DATE)", con);
                    cmdUpdate.ExecuteNonQuery();

                    // Check available rooms for the requested dates
                    var cmdCount = new SqlCommand(@"
                SELECT COUNT(*) FROM Booking
                WHERE RoomID=@RoomID
                  AND Status='Active'
                  AND @StartDate <= EndDate
                  AND @EndDate >= StartDate", con);

                    cmdCount.Parameters.AddWithValue("@RoomID", sessionData["RoomID"]);
                    cmdCount.Parameters.AddWithValue("@StartDate", start);
                    cmdCount.Parameters.AddWithValue("@EndDate", end);

                    int bookedCount = Convert.ToInt32(cmdCount.ExecuteScalar());

                    if (bookedCount >= (int)sessionData["RoomQuantity"])
                    {
                        AppendBotMessage("❌ Room not available for the selected dates. Choose another date or room.");
                        return;
                    }

                    sessionData["TotalCost"] = ((decimal)sessionData["CostPerDay"]) * d;
                    AppendBotMessage($"Total Cost: {sessionData["TotalCost"]} TK\nType 'confirm' to book or 'cancel'");
                    currentHandler = HandleRoom_Confirm;
                }
            }
            catch (Exception ex) { AppendBotMessage("Error: " + ex.Message); }
        }

        private void HandleRoom_Confirm(string input)
        {
            if (input.ToLower() != "confirm") { AppendBotMessage("Room booking cancelled."); Start(); return; }

            try
            {
                DateTime start = (DateTime)sessionData["StartDate"];
                int days = (int)sessionData["Duration"];
                DateTime end = start.AddDays(days - 1);

                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand(@"
                INSERT INTO Booking (PatientID, RoomID, StartDate, EndDate, CostPerDay, TotalCost, Status)
                VALUES (@PID, @RID, @Start, @End, @CostPerDay, @TotalCost, 'Active')", con);

                    cmd.Parameters.AddWithValue("@PID", sessionData["PatientID"]);
                    cmd.Parameters.AddWithValue("@RID", sessionData["RoomID"]);
                    cmd.Parameters.AddWithValue("@Start", start);
                    cmd.Parameters.AddWithValue("@End", end);
                    cmd.Parameters.AddWithValue("@CostPerDay", sessionData["CostPerDay"]);
                    cmd.Parameters.AddWithValue("@TotalCost", sessionData["TotalCost"]);
                    cmd.ExecuteNonQuery();
                }

                AppendBotMessage($"✅ Room booked from {start:dd-MM-yyyy} to {end:dd-MM-yyyy}. Status: Active.");
            }
            catch (Exception ex) { AppendBotMessage("Error: " + ex.Message); }

            Start();
        }

        private void ShowPatientHistory()
        {
            if (!sessionData.ContainsKey("PatientID"))
            {
                AppendBotMessage("⚠️ Please login or admit patient first!");
                Start();
                return;
            }

            int pid = (int)sessionData["PatientID"];
            StringBuilder sb = new StringBuilder();

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // ---------------- APPOINTMENTS ----------------
                    var cmdAppt = new SqlCommand(
                        "SELECT AppointmentID, DoctorID, AppointmentDate, Cost FROM Appointment WHERE PatientID=@PID", con);
                    cmdAppt.Parameters.AddWithValue("@PID", pid);
                    using (var reader = cmdAppt.ExecuteReader())
                    {
                        sb.AppendLine("📅 Appointments:");
                        if (!reader.HasRows) sb.AppendLine("No appointments.");
                        while (reader.Read())
                        {
                            sb.AppendLine($"ID:{reader["AppointmentID"]} DoctorID:{reader["DoctorID"]} " +
                                          $"Date:{((DateTime)reader["AppointmentDate"]).ToString("dd-MM-yyyy")} Cost:{reader["Cost"]} TK");
                        }
                    }

                    sb.AppendLine();

                    // ---------------- TEST ORDERS ----------------
                    var cmdTest = new SqlCommand(
                        "SELECT OrderID, TestNames, TotalCost, Status FROM TestOrder WHERE PatientID=@PID", con);
                    cmdTest.Parameters.AddWithValue("@PID", pid);
                    using (var reader = cmdTest.ExecuteReader())
                    {
                        sb.AppendLine("🧪 Test Orders:");
                        if (!reader.HasRows) sb.AppendLine("No test orders.");
                        while (reader.Read())
                        {
                            sb.AppendLine($"OrderID:{reader["OrderID"]} Tests:{reader["TestNames"]} " +
                                          $"Cost:{reader["TotalCost"]} TK Status:{reader["Status"]}");
                        }
                    }

                    sb.AppendLine();

                    // ---------------- ROOM BOOKINGS ----------------
                    var cmdRoom = new SqlCommand(
                        "SELECT BookingID, RoomID, StartDate, EndDate, TotalCost, Status FROM Booking WHERE PatientID=@PID", con);
                    cmdRoom.Parameters.AddWithValue("@PID", pid);
                    using (var reader = cmdRoom.ExecuteReader())
                    {
                        sb.AppendLine("🏨 Room Bookings:");
                        if (!reader.HasRows) sb.AppendLine("No room bookings.");
                        while (reader.Read())
                        {
                            sb.AppendLine($"BookingID:{reader["BookingID"]} RoomID:{reader["RoomID"]} " +
                                          $"From:{((DateTime)reader["StartDate"]).ToString("dd-MM-yyyy")} " +
                                          $"To:{((DateTime)reader["EndDate"]).ToString("dd-MM-yyyy")} " +
                                          $"Cost:{reader["TotalCost"]} TK Status:{reader["Status"]}");
                        }
                    }

                    sb.AppendLine();

                    // ---------------- COST SUMMARY ----------------
                    decimal totalPaid = 0;
                    decimal totalDue = 0;

                    // Paid test cost
                    var cmdPaidTest = new SqlCommand(
                        "SELECT ISNULL(SUM(TotalCost),0) FROM TestOrder WHERE PatientID=@PID AND Status='Paid'", con);
                    cmdPaidTest.Parameters.AddWithValue("@PID", pid);
                    totalPaid += Convert.ToDecimal(cmdPaidTest.ExecuteScalar());

                    // Unpaid test cost
                    var cmdDueTest = new SqlCommand(
                        "SELECT ISNULL(SUM(TotalCost),0) FROM TestOrder WHERE PatientID=@PID AND Status='Unpaid'", con);
                    cmdDueTest.Parameters.AddWithValue("@PID", pid);
                    totalDue += Convert.ToDecimal(cmdDueTest.ExecuteScalar());

                    // Room bookings
                    var cmdPaidRoom = new SqlCommand(
                        "SELECT ISNULL(SUM(TotalCost),0) FROM Booking WHERE PatientID=@PID AND Status='Paid'", con);
                    cmdPaidRoom.Parameters.AddWithValue("@PID", pid);
                    totalPaid += Convert.ToDecimal(cmdPaidRoom.ExecuteScalar());

                    var cmdDueRoom = new SqlCommand(
                        "SELECT ISNULL(SUM(TotalCost),0) FROM Booking WHERE PatientID=@PID AND Status='Active'", con);
                    cmdDueRoom.Parameters.AddWithValue("@PID", pid);
                    totalDue += Convert.ToDecimal(cmdDueRoom.ExecuteScalar());

                    sb.AppendLine($"💰 Total Paid: {totalPaid} TK");
                    sb.AppendLine($"💸 Total Due: {totalDue} TK");
                    sb.AppendLine($"🧮 Grand Total: {totalPaid + totalDue} TK");
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine("Error fetching history: " + ex.Message);
            }

            AppendBotMessage(sb.ToString());
            Start();
        }
        // -------------------- BILLING / PAYMENT --------------------
        // ---------------- Start Billing ----------------
        private void StartBilling()
        {
            if (!sessionData.ContainsKey("PatientID"))
            {
                AppendBotMessage("⚠️ Please admit or login patient first!");
                Start();
                return;
            }

            // Display current bill info
            decimal total = sessionData.ContainsKey("TotalCost") ? Convert.ToDecimal(sessionData["TotalCost"]) : 1000;
            decimal due = sessionData.ContainsKey("DueAmount") ? Convert.ToDecimal(sessionData["DueAmount"]) : total;

            AppendBotMessage($"💰 Total Amount: {total} TK\n⏳ Due Amount: {due} TK");
            AppendBotMessage("Enter amount you want to pay:");
            currentHandler = HandleBilling_EnterAmount;
        }

        // ---------------- Enter Payment Amount ----------------
        private void HandleBilling_EnterAmount(string input)
        {
            if (!decimal.TryParse(input, out decimal payAmount) || payAmount <= 0)
            {
                AppendBotMessage("❌ Enter a valid amount to pay:");
                return;
            }

            sessionData["PayAmount"] = payAmount;

            AppendBotMessage("💳 Online Payment Methods:\n1. Bkash\n2. Nagad\n3. Visa / MasterCard\nEnter option number:");
            currentHandler = HandleBilling_Method;
        }

        // ---------------- Choose Payment Method ----------------
        private void HandleBilling_Method(string input)
        {
            switch (input.Trim())
            {
                case "1":
                case "2":
                    sessionData["PaymentMethod"] = input == "1" ? "Bkash" : "Nagad";
                    AppendBotMessage($"Enter {sessionData["PaymentMethod"]} Number (11 digits):");
                    currentHandler = HandleBilling_Mobile;
                    break;
                case "3":
                    sessionData["PaymentMethod"] = "Card";
                    AppendBotMessage("Enter 16-digit card number:");
                    currentHandler = HandleBilling_CardNumber;
                    break;
                default:
                    AppendBotMessage("❌ Invalid choice. Enter 1, 2, or 3:");
                    break;
            }
        }

        // ---------------- Mobile Payment ----------------
        private void HandleBilling_Mobile(string mobile)
        {
            if (!long.TryParse(mobile, out long num) || mobile.Length != 11)
            {
                AppendBotMessage("❌ Invalid number. Enter 11-digit mobile number:");
                return;
            }

            sessionData["MobileNumber"] = mobile;
            AppendBotMessage("Enter your email address to receive verification code:");
            currentHandler = HandleBilling_Email;
        }

        private void HandleBilling_Email(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                AppendBotMessage("❌ Invalid email. Enter again:");
                return;
            }

            sessionData["Email"] = email;

            // Generate 4-digit verification code
            Random rnd = new Random();
            int verificationCode = rnd.Next(1000, 9999);
            sessionData["VerificationCode"] = verificationCode;

            AppendBotMessage($"📧 A 4-digit code has been sent to {email}. Enter it below:");
            SendVerificationEmail(email, verificationCode);
            currentHandler = HandleBilling_VerifyCode;
        }

        private void HandleBilling_VerifyCode(string input)
        {
            if (!int.TryParse(input, out int code))
            {
                AppendBotMessage("Enter digits only:");
                return;
            }

            if (code != (int)sessionData["VerificationCode"])
            {
                AppendBotMessage("❌ Incorrect code. Enter again:");
                return;
            }

            AppendBotMessage("✅ Payment verified successfully!");

            // For Bkash/Nagad, auto-send confirmation email
            SavePayment(sessionData["PaymentMethod"].ToString(), autoSendEmail: true);
        }


        // ---------------- Card Payment ----------------
        private void HandleBilling_CardNumber(string card)
        {
            if (card.Length != 16 || !card.All(Char.IsDigit))
            {
                AppendBotMessage("❌ Invalid card number. Enter 16 digits:");
                return;
            }

            sessionData["CardNumber"] = card;
            AppendBotMessage("Enter expiry date (MM/YY):");
            currentHandler = HandleBilling_CardExpiry;
        }

        private void HandleBilling_CardExpiry(string expiry)
        {
            if (!DateTime.TryParseExact("01-" + expiry, "dd-MM/yy", null, DateTimeStyles.None, out DateTime dt))
            {
                AppendBotMessage("❌ Invalid expiry format. Enter MM/YY:");
                return;
            }

            sessionData["CardExpiry"] = expiry;
            AppendBotMessage("Enter CVV (3 digits):");
            currentHandler = HandleBilling_CardCVV;
        }

        private void HandleBilling_CardCVV(string cvv)
        {
            if (cvv.Length != 3 || !cvv.All(Char.IsDigit))
            {
                AppendBotMessage("❌ Invalid CVV. Enter 3 digits:");
                return;
            }

            sessionData["CardCVV"] = cvv;
            AppendBotMessage("✅ Card details verified. Processing payment...");
            SavePayment("Card");
        }

        // ---------------- Save Payment ----------------
        private void SavePayment(string method, bool autoSendEmail = false)
        {
            try
            {
                decimal payAmount = sessionData.ContainsKey("PayAmount") ? Convert.ToDecimal(sessionData["PayAmount"]) : 0;
                decimal totalAmount = sessionData.ContainsKey("TotalCost") ? Convert.ToDecimal(sessionData["TotalCost"]) : payAmount;
                decimal dueAmount = totalAmount - payAmount;

                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand(@"
                INSERT INTO Payments (PatientID, PatientName, TotalAmount, PaidAmount, DueAmount, PaymentDate, Status)
                VALUES (@PID, @Name, @Total, @Paid, @Due, @Date, 'Paid')", con);

                    cmd.Parameters.AddWithValue("@PID", sessionData["PatientID"]);
                    cmd.Parameters.AddWithValue("@Name", sessionData["PatientName"]);
                    cmd.Parameters.AddWithValue("@Total", totalAmount);
                    cmd.Parameters.AddWithValue("@Paid", payAmount);
                    cmd.Parameters.AddWithValue("@Due", dueAmount);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }

                AppendBotMessage($"✅ Payment of {payAmount} TK completed using {method}!");
                sessionData["DueAmount"] = dueAmount;

                if (autoSendEmail)
                {
                    // Auto send email for Bkash/Nagad
                    if (sessionData.ContainsKey("Email"))
                    {
                        SendPaymentEmail(method, payAmount);
                    }
                }
                else
                {
                    // Ask user if they want email confirmation (for Card)
                    AskEmailConfirmation(method, payAmount);
                }
            }
            catch (Exception ex)
            {
                AppendBotMessage("Error saving payment: " + ex.Message);
            }

            Start();
        }

        private void AskEmailConfirmation(string method, decimal amount)
        {
            AppendBotMessage("Do you want payment confirmation via email? (Y/N)");
            sessionData["PendingPaymentMethod"] = method;
            sessionData["PendingPaymentAmount"] = amount;
            currentHandler = HandlePaymentEmailConfirmation;
        }
        private void HandlePaymentEmailConfirmation(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                AppendBotMessage("Enter Y or N:");
                return;
            }
            string answer = input.Trim().ToLower();
            if (answer == "y" || answer == "yes")
            {
                AppendBotMessage("Please enter your valid email address:");
                currentHandler = HandleBilling_EmailForConfirmation;
            }
            else if (answer == "n" || answer == "no")
            {
                AppendBotMessage("✅ Payment process completed without email confirmation.");
                Start();
            }
            else
            {
                AppendBotMessage("Enter Y or N:");
            }
        }
        private void HandleBilling_EmailForConfirmation(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                AppendBotMessage("❌ Invalid email. Enter again:");
                return;
            }

            sessionData["Email"] = email;
            SendPaymentEmail(sessionData["PendingPaymentMethod"].ToString(), Convert.ToDecimal(sessionData["PendingPaymentAmount"]));
            Start();
        }

        // ---------------- Send Verification Email ----------------
        private void SendVerificationEmail(string email, int code)
        {
            try
            {
                var fromAddress = new MailAddress("medicarehospital100@gmail.com", "Hospital System");
                var toAddress = new MailAddress(email);
                string fromPassword =
    Environment.GetEnvironmentVariable("HOSPITAL_SMTP_APP_PASSWORD"); // Gmail App Password

                using (var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                })
                {
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = "Verification Code",
                        Body = $"Your 4-digit verification code is: {code}"
                    })
                    {
                        smtp.Send(message);
                    }
                }

                AppendBotMessage("📧 Verification email sent!");
            }
            catch (Exception ex)
            {
                AppendBotMessage("Error sending email: " + ex.Message);
            }
        }

        // ---------------- Send Payment Confirmation ----------------
        private void SendPaymentEmail(string method, decimal amount)
        {
            if (!sessionData.ContainsKey("Email")) return;

            try
            {
                var fromAddress = new MailAddress("medicarehospital100@gmail.com", "Hospital System");
                var toAddress = new MailAddress(sessionData["Email"].ToString());
                string fromPassword =
                Environment.GetEnvironmentVariable("HOSPITAL_SMTP_APP_PASSWORD"); // Gmail App Password

                using (var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                })
                {
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = "Payment Confirmation",
                        Body = $"Dear {sessionData["PatientName"]},\n\n" +
                               $"Your payment of {amount} TK has been received.\n" +
                               $"Payment Method: {method}\n" +
                               $"Date & Time: {DateTime.Now}\n" +
                               $"Remaining Due: {sessionData["DueAmount"] ?? 0} TK\n\nThank you!"
                    })
                    {
                        smtp.Send(message);
                    }
                }

                AppendBotMessage("✅ Email confirmation sent!");
            }
            catch (Exception ex)
            {
                AppendBotMessage("Error sending email: " + ex.Message);
            }
        }

        // ================= Billing End =================



        private void btnSend_Click_1(object sender, EventArgs e)
        {

            HandleInput(txtusermassage.Text);
            txtusermassage.Clear();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            LogingFrom l1 = new LogingFrom();
            l1.Show();
            this.Hide();
        }
       
        private void btnAdmission_Click_1(object sender, EventArgs e)
        {
            
                HandleInput("1");
           }

        private void btnAppointment_Click_1(object sender, EventArgs e)
        {
            HandleInput("2");
        }

        private void btnRoom_Click_1(object sender, EventArgs e)
        {
            HandleInput("4");
        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            HandleInput("3");
        }

        private void btnBilling_Click_1(object sender, EventArgs e)
        {
            StartBilling();
        }

        private void btnHistory_Click_1(object sender, EventArgs e)
        {
            ShowPatientHistory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtChatBot.Clear();
            Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}


