namespace Hospital_Management_System
{
    partial class Balance
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnfilter = new System.Windows.Forms.Button();
            this.chkAllTime = new System.Windows.Forms.CheckBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvHBalance = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnSALARY = new System.Windows.Forms.Button();
            this.btnpeient = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.txtManualExpense = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlshow = new System.Windows.Forms.Panel();
            this.lblShow = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHBalance)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlshow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOSPITAL BALANCE ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 70);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.btnfilter);
            this.panel2.Controls.Add(this.chkAllTime);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 159);
            this.panel2.TabIndex = 2;
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.Color.YellowGreen;
            this.btnfilter.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.Location = new System.Drawing.Point(409, 94);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(208, 53);
            this.btnfilter.TabIndex = 3;
            this.btnfilter.Text = "SEARCH";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // chkAllTime
            // 
            this.chkAllTime.AutoSize = true;
            this.chkAllTime.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllTime.Location = new System.Drawing.Point(68, 94);
            this.chkAllTime.Name = "chkAllTime";
            this.chkAllTime.Size = new System.Drawing.Size(111, 31);
            this.chkAllTime.TabIndex = 2;
            this.chkAllTime.Text = "All Time";
            this.chkAllTime.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(635, 37);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(320, 32);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(176, 34);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(320, 32);
            this.dtpFrom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(529, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date To :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date From :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvHBalance);
            this.panel3.Location = new System.Drawing.Point(0, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 234);
            this.panel3.TabIndex = 3;
            // 
            // dgvHBalance
            // 
            this.dgvHBalance.AllowUserToAddRows = false;
            this.dgvHBalance.AllowUserToDeleteRows = false;
            this.dgvHBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHBalance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHBalance.Location = new System.Drawing.Point(3, 3);
            this.dgvHBalance.Name = "dgvHBalance";
            this.dgvHBalance.ReadOnly = true;
            this.dgvHBalance.RowHeadersWidth = 62;
            this.dgvHBalance.RowTemplate.Height = 28;
            this.dgvHBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHBalance.Size = new System.Drawing.Size(1052, 214);
            this.dgvHBalance.TabIndex = 0;
            this.dgvHBalance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHBalance_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnback);
            this.panel4.Controls.Add(this.btnSALARY);
            this.panel4.Controls.Add(this.btnpeient);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.btnAddExpense);
            this.panel4.Controls.Add(this.txtManualExpense);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 493);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1058, 330);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlshow);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtBalance);
            this.panel5.Controls.Add(this.txtExpenses);
            this.panel5.Controls.Add(this.txtTotalIncome);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(45, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(955, 160);
            this.panel5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Expense :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Balance :";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(165, 95);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(263, 34);
            this.txtBalance.TabIndex = 1;
            // 
            // txtExpenses
            // 
            this.txtExpenses.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenses.Location = new System.Drawing.Point(647, 32);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.ReadOnly = true;
            this.txtExpenses.Size = new System.Drawing.Size(143, 34);
            this.txtExpenses.TabIndex = 1;
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIncome.Location = new System.Drawing.Point(241, 31);
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.ReadOnly = true;
            this.txtTotalIncome.Size = new System.Drawing.Size(143, 34);
            this.txtTotalIncome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Income :";
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnback.Location = new System.Drawing.Point(934, 274);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 49);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnSALARY
            // 
            this.btnSALARY.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSALARY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALARY.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSALARY.Location = new System.Drawing.Point(483, 274);
            this.btnSALARY.Name = "btnSALARY";
            this.btnSALARY.Size = new System.Drawing.Size(308, 49);
            this.btnSALARY.TabIndex = 2;
            this.btnSALARY.Text = "SALARY DETAILS";
            this.btnSALARY.UseVisualStyleBackColor = false;
            this.btnSALARY.Click += new System.EventHandler(this.btnSALARY_Click);
            // 
            // btnpeient
            // 
            this.btnpeient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpeient.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnpeient.Location = new System.Drawing.Point(252, 274);
            this.btnpeient.Name = "btnpeient";
            this.btnpeient.Size = new System.Drawing.Size(153, 49);
            this.btnpeient.TabIndex = 2;
            this.btnpeient.Text = "Print";
            this.btnpeient.UseVisualStyleBackColor = true;
            this.btnpeient.Click += new System.EventHandler(this.btnpeient_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRefresh.Location = new System.Drawing.Point(27, 274);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(143, 49);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddExpense.Location = new System.Drawing.Point(534, 20);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(175, 49);
            this.btnAddExpense.TabIndex = 2;
            this.btnAddExpense.Text = "Add Expense\r\n";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // txtManualExpense
            // 
            this.txtManualExpense.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManualExpense.Location = new System.Drawing.Point(362, 29);
            this.txtManualExpense.Name = "txtManualExpense";
            this.txtManualExpense.Size = new System.Drawing.Size(143, 34);
            this.txtManualExpense.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Additional Expense Entry :";
            // 
            // pnlshow
            // 
            this.pnlshow.Controls.Add(this.lblShow);
            this.pnlshow.Location = new System.Drawing.Point(460, 95);
            this.pnlshow.Name = "pnlshow";
            this.pnlshow.Size = new System.Drawing.Size(476, 45);
            this.pnlshow.TabIndex = 4;
            this.pnlshow.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlshow_Paint);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(3, 5);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(74, 29);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "label8";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1058, 828);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHBalance)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlshow.ResumeLayout(false);
            this.pnlshow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.CheckBox chkAllTime;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvHBalance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.TextBox txtManualExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnpeient;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSALARY;
        private System.Windows.Forms.Panel pnlshow;
        private System.Windows.Forms.Label lblShow;
    }
}