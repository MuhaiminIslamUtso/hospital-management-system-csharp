namespace Hospital_Management_System
{
    partial class RcBilling
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
            this.cmbBillPAID = new System.Windows.Forms.ComboBox();
            this.txtBillPaid = new System.Windows.Forms.TextBox();
            this.txtTCost = new System.Windows.Forms.TextBox();
            this.txtPNBilling = new System.Windows.Forms.TextBox();
            this.btnTestRefreshre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblwhat = new System.Windows.Forms.Label();
            this.btnrtestSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTestHeading = new System.Windows.Forms.Label();
            this.btnTestBackre = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dvgpatientBill = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPramentSlip = new System.Windows.Forms.Button();
            this.btnBillingPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnpaid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpatientBill)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBillPAID);
            this.panel1.Controls.Add(this.txtBillPaid);
            this.panel1.Controls.Add(this.txtTCost);
            this.panel1.Controls.Add(this.txtPNBilling);
            this.panel1.Controls.Add(this.btnTestRefreshre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblwhat);
            this.panel1.Controls.Add(this.btnrtestSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 270);
            this.panel1.TabIndex = 0;
            // 
            // cmbBillPAID
            // 
            this.cmbBillPAID.FormattingEnabled = true;
            this.cmbBillPAID.Location = new System.Drawing.Point(187, 114);
            this.cmbBillPAID.Name = "cmbBillPAID";
            this.cmbBillPAID.Size = new System.Drawing.Size(121, 28);
            this.cmbBillPAID.TabIndex = 16;
            this.cmbBillPAID.SelectedIndexChanged += new System.EventHandler(this.cmbBillPAID_SelectedIndexChanged);
            // 
            // txtBillPaid
            // 
            this.txtBillPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillPaid.Location = new System.Drawing.Point(582, 166);
            this.txtBillPaid.Name = "txtBillPaid";
            this.txtBillPaid.Size = new System.Drawing.Size(115, 35);
            this.txtBillPaid.TabIndex = 15;
            // 
            // txtTCost
            // 
            this.txtTCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCost.Location = new System.Drawing.Point(549, 108);
            this.txtTCost.Name = "txtTCost";
            this.txtTCost.Size = new System.Drawing.Size(148, 35);
            this.txtTCost.TabIndex = 15;
            // 
            // txtPNBilling
            // 
            this.txtPNBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNBilling.Location = new System.Drawing.Point(187, 161);
            this.txtPNBilling.Name = "txtPNBilling";
            this.txtPNBilling.Size = new System.Drawing.Size(164, 35);
            this.txtPNBilling.TabIndex = 15;
            // 
            // btnTestRefreshre
            // 
            this.btnTestRefreshre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTestRefreshre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestRefreshre.Location = new System.Drawing.Point(767, 220);
            this.btnTestRefreshre.Name = "btnTestRefreshre";
            this.btnTestRefreshre.Size = new System.Drawing.Size(97, 40);
            this.btnTestRefreshre.TabIndex = 13;
            this.btnTestRefreshre.Text = "Refresh";
            this.btnTestRefreshre.UseVisualStyleBackColor = false;
            this.btnTestRefreshre.Click += new System.EventHandler(this.btnTestRefreshre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Paid Balance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Cost :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Patient Name :";
            // 
            // lblwhat
            // 
            this.lblwhat.AutoSize = true;
            this.lblwhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwhat.Location = new System.Drawing.Point(49, 113);
            this.lblwhat.Name = "lblwhat";
            this.lblwhat.Size = new System.Drawing.Size(132, 26);
            this.lblwhat.TabIndex = 12;
            this.lblwhat.Text = "Patient ID :";
            // 
            // btnrtestSearch
            // 
            this.btnrtestSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnrtestSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrtestSearch.Location = new System.Drawing.Point(320, 220);
            this.btnrtestSearch.Name = "btnrtestSearch";
            this.btnrtestSearch.Size = new System.Drawing.Size(119, 43);
            this.btnrtestSearch.TabIndex = 11;
            this.btnrtestSearch.Text = "SEARCH";
            this.btnrtestSearch.UseVisualStyleBackColor = false;
            this.btnrtestSearch.Click += new System.EventHandler(this.btnrtestSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.lblTestHeading);
            this.panel2.Location = new System.Drawing.Point(192, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 67);
            this.panel2.TabIndex = 10;
            // 
            // lblTestHeading
            // 
            this.lblTestHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestHeading.AutoSize = true;
            this.lblTestHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestHeading.Location = new System.Drawing.Point(20, 14);
            this.lblTestHeading.Name = "lblTestHeading";
            this.lblTestHeading.Size = new System.Drawing.Size(444, 40);
            this.lblTestHeading.TabIndex = 0;
            this.lblTestHeading.Text = "BILLING AND PREMENT";
            // 
            // btnTestBackre
            // 
            this.btnTestBackre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTestBackre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestBackre.Location = new System.Drawing.Point(729, 110);
            this.btnTestBackre.Name = "btnTestBackre";
            this.btnTestBackre.Size = new System.Drawing.Size(135, 71);
            this.btnTestBackre.TabIndex = 14;
            this.btnTestBackre.Text = "Back";
            this.btnTestBackre.UseVisualStyleBackColor = false;
            this.btnTestBackre.Click += new System.EventHandler(this.btnTestBackre_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.dvgpatientBill);
            this.panel3.Location = new System.Drawing.Point(2, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 177);
            this.panel3.TabIndex = 1;
            // 
            // dvgpatientBill
            // 
            this.dvgpatientBill.AllowUserToAddRows = false;
            this.dvgpatientBill.AllowUserToDeleteRows = false;
            this.dvgpatientBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgpatientBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgpatientBill.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dvgpatientBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgpatientBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgpatientBill.Location = new System.Drawing.Point(0, 0);
            this.dvgpatientBill.Name = "dvgpatientBill";
            this.dvgpatientBill.ReadOnly = true;
            this.dvgpatientBill.RowHeadersWidth = 62;
            this.dvgpatientBill.RowTemplate.Height = 28;
            this.dvgpatientBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgpatientBill.Size = new System.Drawing.Size(871, 177);
            this.dvgpatientBill.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.btnPramentSlip);
            this.panel4.Controls.Add(this.btnBillingPay);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtUnpaid);
            this.panel4.Controls.Add(this.btnTestBackre);
            this.panel4.Location = new System.Drawing.Point(2, 459);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 200);
            this.panel4.TabIndex = 2;
            // 
            // btnPramentSlip
            // 
            this.btnPramentSlip.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPramentSlip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPramentSlip.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnPramentSlip.Location = new System.Drawing.Point(653, 36);
            this.btnPramentSlip.Name = "btnPramentSlip";
            this.btnPramentSlip.Size = new System.Drawing.Size(178, 47);
            this.btnPramentSlip.TabIndex = 16;
            this.btnPramentSlip.Text = "Prament Slip";
            this.btnPramentSlip.UseVisualStyleBackColor = false;
            this.btnPramentSlip.Click += new System.EventHandler(this.btnPramentSlip_Click);
            // 
            // btnBillingPay
            // 
            this.btnBillingPay.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBillingPay.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnBillingPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillingPay.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnBillingPay.Location = new System.Drawing.Point(484, 42);
            this.btnBillingPay.Name = "btnBillingPay";
            this.btnBillingPay.Size = new System.Drawing.Size(120, 47);
            this.btnBillingPay.TabIndex = 16;
            this.btnBillingPay.Text = "Pay";
            this.btnBillingPay.UseVisualStyleBackColor = false;
            this.btnBillingPay.Click += new System.EventHandler(this.btnBillingPay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unpaid Balance :";
            // 
            // txtUnpaid
            // 
            this.txtUnpaid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnpaid.ForeColor = System.Drawing.Color.Red;
            this.txtUnpaid.Location = new System.Drawing.Point(286, 42);
            this.txtUnpaid.Name = "txtUnpaid";
            this.txtUnpaid.ReadOnly = true;
            this.txtUnpaid.Size = new System.Drawing.Size(141, 37);
            this.txtUnpaid.TabIndex = 15;
            // 
            // RcBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 652);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "RcBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RcBilling";
            this.Load += new System.EventHandler(this.RcBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgpatientBill)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTestBackre;
        private System.Windows.Forms.Button btnTestRefreshre;
        private System.Windows.Forms.Label lblwhat;
        private System.Windows.Forms.Button btnrtestSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTestHeading;
        private System.Windows.Forms.TextBox txtPNBilling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillPaid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dvgpatientBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBillingPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnpaid;
        private System.Windows.Forms.Button btnPramentSlip;
        private System.Windows.Forms.ComboBox cmbBillPAID;
    }
}