namespace Hospital_Management_System
{
    partial class Chatbot
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtChatBot = new System.Windows.Forms.RichTextBox();
            this.txtusermassage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::Hospital_Management_System.Properties.Resources.chatbot_4071274_19201;
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // txtChatBot
            // 
            this.txtChatBot.BackColor = System.Drawing.Color.Linen;
            this.txtChatBot.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChatBot.Location = new System.Drawing.Point(8, 47);
            this.txtChatBot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChatBot.Name = "txtChatBot";
            this.txtChatBot.ReadOnly = true;
            this.txtChatBot.Size = new System.Drawing.Size(574, 176);
            this.txtChatBot.TabIndex = 1;
            this.txtChatBot.Text = "";
            // 
            // txtusermassage
            // 
            this.txtusermassage.BackColor = System.Drawing.Color.AliceBlue;
            this.txtusermassage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusermassage.Location = new System.Drawing.Point(14, 14);
            this.txtusermassage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusermassage.Multiline = true;
            this.txtusermassage.Name = "txtusermassage";
            this.txtusermassage.Size = new System.Drawing.Size(459, 38);
            this.txtusermassage.TabIndex = 2;
            this.txtusermassage.Text = "\r\n";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(487, 22);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(81, 28);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 42);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOSPITAL CHATBOT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHistory);
            this.panel3.Controls.Add(this.btnBilling);
            this.panel3.Controls.Add(this.btnTest);
            this.panel3.Controls.Add(this.btnRoom);
            this.panel3.Controls.Add(this.btnAppointment);
            this.panel3.Controls.Add(this.btnAdmission);
            this.panel3.Controls.Add(this.txtusermassage);
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(4, 226);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 174);
            this.panel3.TabIndex = 6;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(393, 116);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(165, 30);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click_1);
            // 
            // btnBilling
            // 
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.Location = new System.Drawing.Point(203, 116);
            this.btnBilling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(183, 30);
            this.btnBilling.TabIndex = 5;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click_1);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(14, 116);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(172, 30);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test Order";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click_1);
            // 
            // btnRoom
            // 
            this.btnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Location = new System.Drawing.Point(393, 67);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(165, 30);
            this.btnRoom.TabIndex = 5;
            this.btnRoom.Text = "Room Booking";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click_1);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.Location = new System.Drawing.Point(203, 67);
            this.btnAppointment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(183, 30);
            this.btnAppointment.TabIndex = 5;
            this.btnAppointment.Text = "Appoinment";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click_1);
            // 
            // btnAdmission
            // 
            this.btnAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmission.Location = new System.Drawing.Point(20, 67);
            this.btnAdmission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(166, 30);
            this.btnAdmission.TabIndex = 4;
            this.btnAdmission.Text = "Patient Admission";
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Location = new System.Drawing.Point(477, 404);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Bisque;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(71, 404);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 27);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Chatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 439);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtChatBot);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chatbot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatbot";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtChatBot;
        private System.Windows.Forms.TextBox txtusermassage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
    }
}