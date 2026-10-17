namespace Hospital_Management_System
{
    partial class Salary
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSalaryDetails = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.txtAllSalary = new System.Windows.Forms.TextBox();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.txtNurseSalary = new System.Windows.Forms.TextBox();
            this.txtDoctorSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryDetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALARY DETAILS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSalaryDetails);
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 234);
            this.panel2.TabIndex = 1;
            // 
            // dgvSalaryDetails
            // 
            this.dgvSalaryDetails.AllowUserToAddRows = false;
            this.dgvSalaryDetails.AllowUserToDeleteRows = false;
            this.dgvSalaryDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaryDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalaryDetails.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgvSalaryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSalaryDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvSalaryDetails.Name = "dgvSalaryDetails";
            this.dgvSalaryDetails.ReadOnly = true;
            this.dgvSalaryDetails.RowHeadersWidth = 62;
            this.dgvSalaryDetails.RowTemplate.Height = 28;
            this.dgvSalaryDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaryDetails.Size = new System.Drawing.Size(1051, 234);
            this.dgvSalaryDetails.TabIndex = 0;
            this.dgvSalaryDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryDetails_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.btnback);
            this.panel3.Controls.Add(this.txtAllSalary);
            this.panel3.Controls.Add(this.txtEmployeeSalary);
            this.panel3.Controls.Add(this.txtMonthlySalary);
            this.panel3.Controls.Add(this.txtNurseSalary);
            this.panel3.Controls.Add(this.txtDoctorSalary);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 314);
            this.panel3.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Khaki;
            this.btnback.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(943, 250);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(96, 52);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtAllSalary
            // 
            this.txtAllSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllSalary.Location = new System.Drawing.Point(432, 166);
            this.txtAllSalary.Name = "txtAllSalary";
            this.txtAllSalary.ReadOnly = true;
            this.txtAllSalary.Size = new System.Drawing.Size(327, 32);
            this.txtAllSalary.TabIndex = 1;
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSalary.Location = new System.Drawing.Point(320, 110);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.ReadOnly = true;
            this.txtEmployeeSalary.Size = new System.Drawing.Size(204, 30);
            this.txtEmployeeSalary.TabIndex = 1;
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlySalary.Location = new System.Drawing.Point(835, 109);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.ReadOnly = true;
            this.txtMonthlySalary.Size = new System.Drawing.Size(204, 30);
            this.txtMonthlySalary.TabIndex = 1;
            // 
            // txtNurseSalary
            // 
            this.txtNurseSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNurseSalary.Location = new System.Drawing.Point(835, 54);
            this.txtNurseSalary.Name = "txtNurseSalary";
            this.txtNurseSalary.ReadOnly = true;
            this.txtNurseSalary.Size = new System.Drawing.Size(204, 30);
            this.txtNurseSalary.TabIndex = 1;
            // 
            // txtDoctorSalary
            // 
            this.txtDoctorSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorSalary.Location = new System.Drawing.Point(320, 54);
            this.txtDoctorSalary.Name = "txtDoctorSalary";
            this.txtDoctorSalary.ReadOnly = true;
            this.txtDoctorSalary.Size = new System.Drawing.Size(204, 30);
            this.txtDoctorSalary.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 58);
            this.label6.TabIndex = 0;
            this.label6.Text = "All Salary (All Time) :\r\n ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(545, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total  Salary This Month :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Employee Salary :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Nurse Salary :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Doctor Salary :";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 644);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSalaryDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.TextBox txtMonthlySalary;
        private System.Windows.Forms.TextBox txtNurseSalary;
        private System.Windows.Forms.TextBox txtDoctorSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtAllSalary;
    }
}