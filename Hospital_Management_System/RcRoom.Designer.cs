namespace Hospital_Management_System
{
    partial class RcRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.dtpBooking = new System.Windows.Forms.DateTimePicker();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.btnSearchAvailability = new System.Windows.Forms.Button();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dvgPRBooking = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbone = new System.Windows.Forms.ComboBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnRCBACK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtrmTotalCost = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtBookingDuration = new System.Windows.Forms.TextBox();
            this.txtCostPerDay = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPRBooking)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtDuration);
            this.panel2.Controls.Add(this.dtpBooking);
            this.panel2.Controls.Add(this.txtAvailability);
            this.panel2.Controls.Add(this.btnSearchAvailability);
            this.panel2.Controls.Add(this.cmbRoomType);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 187);
            this.panel2.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(626, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 26);
            this.label13.TabIndex = 18;
            this.label13.Text = "Days";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(551, 58);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(50, 35);
            this.txtDuration.TabIndex = 17;
            // 
            // dtpBooking
            // 
            this.dtpBooking.Location = new System.Drawing.Point(551, 15);
            this.dtpBooking.Name = "dtpBooking";
            this.dtpBooking.Size = new System.Drawing.Size(286, 26);
            this.dtpBooking.TabIndex = 16;
            // 
            // txtAvailability
            // 
            this.txtAvailability.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailability.Location = new System.Drawing.Point(12, 127);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(813, 42);
            this.txtAvailability.TabIndex = 15;
            // 
            // btnSearchAvailability
            // 
            this.btnSearchAvailability.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAvailability.Location = new System.Drawing.Point(108, 63);
            this.btnSearchAvailability.Name = "btnSearchAvailability";
            this.btnSearchAvailability.Size = new System.Drawing.Size(197, 45);
            this.btnSearchAvailability.TabIndex = 14;
            this.btnSearchAvailability.Text = "Search";
            this.btnSearchAvailability.UseVisualStyleBackColor = false;
            this.btnSearchAvailability.Click += new System.EventHandler(this.btnSearchAvailability_Click);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "General World",
            "ICU",
            "PRIVATE"});
            this.cmbRoomType.Location = new System.Drawing.Point(198, 15);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(146, 28);
            this.cmbRoomType.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(353, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "patient will stay :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(369, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Admission Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(29, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "ROOM TYPE :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dvgPRBooking);
            this.panel3.Location = new System.Drawing.Point(0, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 154);
            this.panel3.TabIndex = 2;
            // 
            // dvgPRBooking
            // 
            this.dvgPRBooking.AllowUserToAddRows = false;
            this.dvgPRBooking.AllowUserToDeleteRows = false;
            this.dvgPRBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPRBooking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgPRBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPRBooking.Location = new System.Drawing.Point(-3, 3);
            this.dvgPRBooking.Name = "dvgPRBooking";
            this.dvgPRBooking.ReadOnly = true;
            this.dvgPRBooking.RowHeadersWidth = 62;
            this.dvgPRBooking.RowTemplate.Height = 28;
            this.dvgPRBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPRBooking.Size = new System.Drawing.Size(847, 148);
            this.dvgPRBooking.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel4.Controls.Add(this.cmbone);
            this.panel4.Controls.Add(this.btnBooking);
            this.panel4.Controls.Add(this.btnRCBACK);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtBookingDate);
            this.panel4.Controls.Add(this.txtDiscount);
            this.panel4.Controls.Add(this.txtrmTotalCost);
            this.panel4.Controls.Add(this.txtRoomNumber);
            this.panel4.Controls.Add(this.txtBookingDuration);
            this.panel4.Controls.Add(this.txtCostPerDay);
            this.panel4.Controls.Add(this.txtRoomID);
            this.panel4.Controls.Add(this.txtPatientID);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(844, 330);
            this.panel4.TabIndex = 3;
            // 
            // cmbone
            // 
            this.cmbone.FormattingEnabled = true;
            this.cmbone.Location = new System.Drawing.Point(186, 39);
            this.cmbone.Name = "cmbone";
            this.cmbone.Size = new System.Drawing.Size(215, 28);
            this.cmbone.TabIndex = 13;
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(316, 276);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(151, 43);
            this.btnBooking.TabIndex = 12;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnRCBACK
            // 
            this.btnRCBACK.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRCBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRCBACK.Location = new System.Drawing.Point(708, 278);
            this.btnRCBACK.Name = "btnRCBACK";
            this.btnRCBACK.Size = new System.Drawing.Size(133, 49);
            this.btnRCBACK.TabIndex = 11;
            this.btnRCBACK.Text = "Back";
            this.btnRCBACK.UseVisualStyleBackColor = false;
            this.btnRCBACK.Click += new System.EventHandler(this.btnRCBACK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(770, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "Days";
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Location = new System.Drawing.Point(165, 161);
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.Size = new System.Drawing.Size(273, 26);
            this.txtBookingDate.TabIndex = 8;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(342, 209);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(109, 26);
            this.txtDiscount.TabIndex = 7;
            // 
            // txtrmTotalCost
            // 
            this.txtrmTotalCost.Location = new System.Drawing.Point(656, 213);
            this.txtrmTotalCost.Name = "txtrmTotalCost";
            this.txtrmTotalCost.Size = new System.Drawing.Size(132, 26);
            this.txtrmTotalCost.TabIndex = 7;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(671, 21);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(109, 26);
            this.txtRoomNumber.TabIndex = 7;
            // 
            // txtBookingDuration
            // 
            this.txtBookingDuration.Location = new System.Drawing.Point(673, 161);
            this.txtBookingDuration.Name = "txtBookingDuration";
            this.txtBookingDuration.Size = new System.Drawing.Size(80, 26);
            this.txtBookingDuration.TabIndex = 7;
            // 
            // txtCostPerDay
            // 
            this.txtCostPerDay.Location = new System.Drawing.Point(673, 106);
            this.txtCostPerDay.Name = "txtCostPerDay";
            this.txtCostPerDay.Size = new System.Drawing.Size(117, 26);
            this.txtCostPerDay.TabIndex = 7;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(671, 69);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(117, 26);
            this.txtRoomID.TabIndex = 7;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(195, 106);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(117, 26);
            this.txtPatientID.TabIndex = 7;
            this.txtPatientID.TextChanged += new System.EventHandler(this.txtPatientID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Room Cost Per Day :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Patient Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Patient Id :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Booking Duration :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(457, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total room cost :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Discount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Booking Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Id :";
            // 
            // RcRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 689);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "RcRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOKING";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPRBooking)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchAvailability;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dvgPRBooking;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtCostPerDay;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtBookingDate;
        private System.Windows.Forms.TextBox txtBookingDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtrmTotalCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRCBACK;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBooking;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.ComboBox cmbone;
        private System.Windows.Forms.Label label14;
    }
}