namespace Hospital_Management_System
{
    partial class Absence
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
            this.btnBackH = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.btnMarkAbsent = new System.Windows.Forms.Button();
            this.txtshowID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAbsenceDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStaffName = new System.Windows.Forms.ComboBox();
            this.cmbStaffType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAbsenceHistory = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btnBackH);
            this.panel1.Controls.Add(this.btnViewHistory);
            this.panel1.Controls.Add(this.btnMarkAbsent);
            this.panel1.Controls.Add(this.txtshowID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpAbsenceDate);
            this.panel1.Controls.Add(this.cmbStaffName);
            this.panel1.Controls.Add(this.cmbStaffType);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 268);
            this.panel1.TabIndex = 0;
            // 
            // btnBackH
            // 
            this.btnBackH.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBackH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackH.Location = new System.Drawing.Point(852, 208);
            this.btnBackH.Name = "btnBackH";
            this.btnBackH.Size = new System.Drawing.Size(147, 57);
            this.btnBackH.TabIndex = 6;
            this.btnBackH.Text = "Back";
            this.btnBackH.UseVisualStyleBackColor = false;
            this.btnBackH.Click += new System.EventHandler(this.btnBackH_Click);
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.BackColor = System.Drawing.Color.Thistle;
            this.btnViewHistory.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHistory.Location = new System.Drawing.Point(419, 195);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(166, 53);
            this.btnViewHistory.TabIndex = 5;
            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.UseVisualStyleBackColor = false;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // btnMarkAbsent
            // 
            this.btnMarkAbsent.BackColor = System.Drawing.Color.Magenta;
            this.btnMarkAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAbsent.Location = new System.Drawing.Point(60, 178);
            this.btnMarkAbsent.Name = "btnMarkAbsent";
            this.btnMarkAbsent.Size = new System.Drawing.Size(227, 54);
            this.btnMarkAbsent.TabIndex = 4;
            this.btnMarkAbsent.Text = "Mark Absent";
            this.btnMarkAbsent.UseVisualStyleBackColor = false;
            this.btnMarkAbsent.Click += new System.EventHandler(this.btnMarkAbsent_Click);
            // 
            // txtshowID
            // 
            this.txtshowID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshowID.Location = new System.Drawing.Point(666, 40);
            this.txtshowID.Name = "txtshowID";
            this.txtshowID.ReadOnly = true;
            this.txtshowID.Size = new System.Drawing.Size(181, 37);
            this.txtshowID.TabIndex = 3;
            this.txtshowID.Text = "  Staff Id";
            //this.txtshowID.TextChanged += new System.EventHandler(this.txtshowID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID :";
            // 
            // dtpAbsenceDate
            // 
            this.dtpAbsenceDate.CalendarFont = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAbsenceDate.Location = new System.Drawing.Point(75, 106);
            this.dtpAbsenceDate.Name = "dtpAbsenceDate";
            this.dtpAbsenceDate.Size = new System.Drawing.Size(302, 26);
            this.dtpAbsenceDate.TabIndex = 1;
            // 
            // cmbStaffName
            // 
            this.cmbStaffName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffName.FormattingEnabled = true;
            this.cmbStaffName.Location = new System.Drawing.Point(343, 40);
            this.cmbStaffName.Name = "cmbStaffName";
            this.cmbStaffName.Size = new System.Drawing.Size(215, 37);
            this.cmbStaffName.TabIndex = 0;
            this.cmbStaffName.Text = " Name";
       //     this.cmbStaffName.SelectedIndexChanged += new System.EventHandler(this.cmbStaffName_SelectedIndexChanged_1);
            // 
            // cmbStaffType
            // 
            this.cmbStaffType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffType.FormattingEnabled = true;
            this.cmbStaffType.Location = new System.Drawing.Point(60, 40);
            this.cmbStaffType.Name = "cmbStaffType";
            this.cmbStaffType.Size = new System.Drawing.Size(215, 37);
            this.cmbStaffType.TabIndex = 0;
            this.cmbStaffType.Text = "Staff Type";
            this.cmbStaffType.SelectedIndexChanged += new System.EventHandler(this.cmbStaffType_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAbsenceHistory);
            this.panel2.Location = new System.Drawing.Point(1, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 452);
            this.panel2.TabIndex = 1;
            // 
            // dgvAbsenceHistory
            // 
            this.dgvAbsenceHistory.AllowUserToAddRows = false;
            this.dgvAbsenceHistory.AllowUserToDeleteRows = false;
            this.dgvAbsenceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbsenceHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAbsenceHistory.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvAbsenceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsenceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbsenceHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvAbsenceHistory.Name = "dgvAbsenceHistory";
            this.dgvAbsenceHistory.ReadOnly = true;
            this.dgvAbsenceHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvAbsenceHistory.RowTemplate.Height = 28;
            this.dgvAbsenceHistory.Size = new System.Drawing.Size(1002, 452);
            this.dgvAbsenceHistory.TabIndex = 0;
            // 
            // Absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Absence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Absence";
            this.Load += new System.EventHandler(this.Absence_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtshowID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAbsenceDate;
        private System.Windows.Forms.ComboBox cmbStaffName;
        private System.Windows.Forms.ComboBox cmbStaffType;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Button btnMarkAbsent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAbsenceHistory;
        private System.Windows.Forms.Button btnBackH;
    }
}