namespace Hospital_Management_System
{
    partial class RcTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RcTest));
            this.pnltestMaster = new System.Windows.Forms.Panel();
            this.btnTp3 = new System.Windows.Forms.Button();
            this.btntp1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTMBack = new System.Windows.Forms.Button();
            this.pnlTesttopatient = new System.Windows.Forms.Panel();
            this.pnlTestBelling = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.btnTestPtintRecept = new System.Windows.Forms.Button();
            this.btnTestpay = new System.Windows.Forms.Button();
            this.btnRefreshre = new System.Windows.Forms.Button();
            this.dgvTestBilling = new System.Windows.Forms.DataGridView();
            this.txtTestDiscount = new System.Windows.Forms.TextBox();
            this.cmbTestPatientName = new System.Windows.Forms.ComboBox();
            this.btnTestToPatientSave = new System.Windows.Forms.Button();
            this.cblTest = new System.Windows.Forms.CheckedListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTotalTestCost = new System.Windows.Forms.TextBox();
            this.txtttpTestCost = new System.Windows.Forms.TextBox();
            this.txtttpContact = new System.Windows.Forms.TextBox();
            this.txtttppatientid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnltestMaster.SuspendLayout();
            this.pnlTesttopatient.SuspendLayout();
            this.pnlTestBelling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltestMaster
            // 
            this.pnltestMaster.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnltestMaster.Controls.Add(this.btnTp3);
            this.pnltestMaster.Controls.Add(this.btntp1);
            this.pnltestMaster.Controls.Add(this.label2);
            this.pnltestMaster.Location = new System.Drawing.Point(214, 59);
            this.pnltestMaster.Name = "pnltestMaster";
            this.pnltestMaster.Size = new System.Drawing.Size(548, 380);
            this.pnltestMaster.TabIndex = 1;
            // 
            // btnTp3
            // 
            this.btnTp3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTp3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTp3.Location = new System.Drawing.Point(119, 190);
            this.btnTp3.Name = "btnTp3";
            this.btnTp3.Size = new System.Drawing.Size(335, 56);
            this.btnTp3.TabIndex = 1;
            this.btnTp3.Text = "2. Pay Test Cost";
            this.btnTp3.UseVisualStyleBackColor = true;
            this.btnTp3.Click += new System.EventHandler(this.btnTp3_Click);
            // 
            // btntp1
            // 
            this.btntp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntp1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntp1.Location = new System.Drawing.Point(119, 106);
            this.btntp1.Name = "btntp1";
            this.btntp1.Size = new System.Drawing.Size(335, 56);
            this.btntp1.TabIndex = 1;
            this.btntp1.Text = "1. Test to patient ";
            this.btntp1.UseVisualStyleBackColor = true;
            this.btntp1.Click += new System.EventHandler(this.btntp1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "Test Management";
            // 
            // btnTMBack
            // 
            this.btnTMBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnTMBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTMBack.Location = new System.Drawing.Point(754, 486);
            this.btnTMBack.Name = "btnTMBack";
            this.btnTMBack.Size = new System.Drawing.Size(127, 66);
            this.btnTMBack.TabIndex = 2;
            this.btnTMBack.Text = "BACK";
            this.btnTMBack.UseVisualStyleBackColor = true;
            this.btnTMBack.Click += new System.EventHandler(this.btnTMBack_Click);
            // 
            // pnlTesttopatient
            // 
            this.pnlTesttopatient.Controls.Add(this.pnlTestBelling);
            this.pnlTesttopatient.Controls.Add(this.txtTestDiscount);
            this.pnlTesttopatient.Controls.Add(this.cmbTestPatientName);
            this.pnlTesttopatient.Controls.Add(this.btnTestToPatientSave);
            this.pnlTesttopatient.Controls.Add(this.cblTest);
            this.pnlTesttopatient.Controls.Add(this.btnBack);
            this.pnlTesttopatient.Controls.Add(this.txtTotalTestCost);
            this.pnlTesttopatient.Controls.Add(this.txtttpTestCost);
            this.pnlTesttopatient.Controls.Add(this.txtttpContact);
            this.pnlTesttopatient.Controls.Add(this.txtttppatientid);
            this.pnlTesttopatient.Controls.Add(this.label8);
            this.pnlTesttopatient.Controls.Add(this.label14);
            this.pnlTesttopatient.Controls.Add(this.label7);
            this.pnlTesttopatient.Controls.Add(this.label1);
            this.pnlTesttopatient.Controls.Add(this.label6);
            this.pnlTesttopatient.Controls.Add(this.label5);
            this.pnlTesttopatient.Controls.Add(this.label4);
            this.pnlTesttopatient.Controls.Add(this.label3);
            this.pnlTesttopatient.Location = new System.Drawing.Point(-2, -6);
            this.pnlTesttopatient.Name = "pnlTesttopatient";
            this.pnlTesttopatient.Size = new System.Drawing.Size(883, 611);
            this.pnlTesttopatient.TabIndex = 3;
            // 
            // pnlTestBelling
            // 
            this.pnlTestBelling.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlTestBelling.Controls.Add(this.BackBtn);
            this.pnlTestBelling.Controls.Add(this.btnTestPtintRecept);
            this.pnlTestBelling.Controls.Add(this.btnTestpay);
            this.pnlTestBelling.Controls.Add(this.btnRefreshre);
            this.pnlTestBelling.Controls.Add(this.dgvTestBilling);
            this.pnlTestBelling.Location = new System.Drawing.Point(0, 3);
            this.pnlTestBelling.Name = "pnlTestBelling";
            this.pnlTestBelling.Size = new System.Drawing.Size(883, 605);
            this.pnlTestBelling.TabIndex = 19;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Wheat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(741, 537);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(139, 53);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // btnTestPtintRecept
            // 
            this.btnTestPtintRecept.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTestPtintRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestPtintRecept.Location = new System.Drawing.Point(475, 400);
            this.btnTestPtintRecept.Name = "btnTestPtintRecept";
            this.btnTestPtintRecept.Size = new System.Drawing.Size(195, 59);
            this.btnTestPtintRecept.TabIndex = 3;
            this.btnTestPtintRecept.Text = "PtintRecept";
            this.btnTestPtintRecept.UseVisualStyleBackColor = false;
            this.btnTestPtintRecept.Click += new System.EventHandler(this.btnTestPtintRecept_Click_1);
            // 
            // btnTestpay
            // 
            this.btnTestpay.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTestpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestpay.Location = new System.Drawing.Point(262, 400);
            this.btnTestpay.Name = "btnTestpay";
            this.btnTestpay.Size = new System.Drawing.Size(122, 59);
            this.btnTestpay.TabIndex = 2;
            this.btnTestpay.Text = "Pay";
            this.btnTestpay.UseVisualStyleBackColor = false;
            this.btnTestpay.Click += new System.EventHandler(this.btnTestpay_Click_1);
            // 
            // btnRefreshre
            // 
            this.btnRefreshre.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRefreshre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshre.Location = new System.Drawing.Point(65, 400);
            this.btnRefreshre.Name = "btnRefreshre";
            this.btnRefreshre.Size = new System.Drawing.Size(130, 59);
            this.btnRefreshre.TabIndex = 1;
            this.btnRefreshre.Text = "Refresh";
            this.btnRefreshre.UseVisualStyleBackColor = false;
            this.btnRefreshre.Click += new System.EventHandler(this.btnRefreshre_Click);
            // 
            // dgvTestBilling
            // 
            this.dgvTestBilling.AllowUserToAddRows = false;
            this.dgvTestBilling.AllowUserToDeleteRows = false;
            this.dgvTestBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestBilling.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTestBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestBilling.Location = new System.Drawing.Point(14, 31);
            this.dgvTestBilling.Name = "dgvTestBilling";
            this.dgvTestBilling.ReadOnly = true;
            this.dgvTestBilling.RowHeadersWidth = 62;
            this.dgvTestBilling.RowTemplate.Height = 28;
            this.dgvTestBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestBilling.Size = new System.Drawing.Size(857, 307);
            this.dgvTestBilling.TabIndex = 0;
            this.dgvTestBilling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTestBilling_CellContentClick);
            // 
            // txtTestDiscount
            // 
            this.txtTestDiscount.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestDiscount.Location = new System.Drawing.Point(190, 206);
            this.txtTestDiscount.Name = "txtTestDiscount";
            this.txtTestDiscount.ReadOnly = true;
            this.txtTestDiscount.Size = new System.Drawing.Size(100, 34);
            this.txtTestDiscount.TabIndex = 17;
            // 
            // cmbTestPatientName
            // 
            this.cmbTestPatientName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTestPatientName.FormattingEnabled = true;
            this.cmbTestPatientName.Location = new System.Drawing.Point(196, 100);
            this.cmbTestPatientName.Name = "cmbTestPatientName";
            this.cmbTestPatientName.Size = new System.Drawing.Size(158, 35);
            this.cmbTestPatientName.TabIndex = 16;
            this.cmbTestPatientName.SelectedIndexChanged += new System.EventHandler(this.cmbTestPatientName_SelectedIndexChanged);
            // 
            // btnTestToPatientSave
            // 
            this.btnTestToPatientSave.BackColor = System.Drawing.Color.Linen;
            this.btnTestToPatientSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestToPatientSave.Location = new System.Drawing.Point(231, 347);
            this.btnTestToPatientSave.Name = "btnTestToPatientSave";
            this.btnTestToPatientSave.Size = new System.Drawing.Size(132, 43);
            this.btnTestToPatientSave.TabIndex = 18;
            this.btnTestToPatientSave.Text = "Save";
            this.btnTestToPatientSave.UseVisualStyleBackColor = false;
            this.btnTestToPatientSave.Click += new System.EventHandler(this.btnTestToPatientSave_Click);
            // 
            // cblTest
            // 
            this.cblTest.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblTest.FormattingEnabled = true;
            this.cblTest.Location = new System.Drawing.Point(193, 155);
            this.cblTest.Name = "cblTest";
            this.cblTest.Size = new System.Drawing.Size(170, 35);
            this.cblTest.TabIndex = 15;
            this.cblTest.SelectedIndexChanged += new System.EventHandler(this.cblTest_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(703, 504);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 56);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTotalTestCost
            // 
            this.txtTotalTestCost.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTestCost.Location = new System.Drawing.Point(544, 204);
            this.txtTotalTestCost.Name = "txtTotalTestCost";
            this.txtTotalTestCost.ReadOnly = true;
            this.txtTotalTestCost.Size = new System.Drawing.Size(133, 34);
            this.txtTotalTestCost.TabIndex = 2;
            // 
            // txtttpTestCost
            // 
            this.txtttpTestCost.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttpTestCost.Location = new System.Drawing.Point(537, 156);
            this.txtttpTestCost.Name = "txtttpTestCost";
            this.txtttpTestCost.ReadOnly = true;
            this.txtttpTestCost.Size = new System.Drawing.Size(140, 34);
            this.txtttpTestCost.TabIndex = 2;
            // 
            // txtttpContact
            // 
            this.txtttpContact.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttpContact.Location = new System.Drawing.Point(350, 273);
            this.txtttpContact.Name = "txtttpContact";
            this.txtttpContact.Size = new System.Drawing.Size(299, 34);
            this.txtttpContact.TabIndex = 2;
            // 
            // txtttppatientid
            // 
            this.txtttppatientid.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttppatientid.Location = new System.Drawing.Point(543, 100);
            this.txtttppatientid.Name = "txtttppatientid";
            this.txtttppatientid.ReadOnly = true;
            this.txtttppatientid.Size = new System.Drawing.Size(120, 34);
            this.txtttppatientid.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Contact for update(email) :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "Discount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Test Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Test Cost :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Test Cost :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Patient Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Patient ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Test To Patient";
            // 
            // RcTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(881, 599);
            this.Controls.Add(this.pnlTesttopatient);
            this.Controls.Add(this.pnltestMaster);
            this.Controls.Add(this.btnTMBack);
            this.Name = "RcTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RcTest";
            this.Load += new System.EventHandler(this.RcTest_Load);
            this.pnltestMaster.ResumeLayout(false);
            this.pnltestMaster.PerformLayout();
            this.pnlTesttopatient.ResumeLayout(false);
            this.pnlTesttopatient.PerformLayout();
            this.pnlTestBelling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestBilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnltestMaster;
        private System.Windows.Forms.Button btntp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTp3;
        private System.Windows.Forms.Button btnTMBack;
        private System.Windows.Forms.Panel pnlTesttopatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtttpTestCost;
        private System.Windows.Forms.TextBox txtttppatientid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtttpContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox cblTest;
        private System.Windows.Forms.TextBox txtTestDiscount;
        private System.Windows.Forms.ComboBox cmbTestPatientName;
        private System.Windows.Forms.TextBox txtTotalTestCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestToPatientSave;
        private System.Windows.Forms.Panel pnlTestBelling;
        private System.Windows.Forms.DataGridView dgvTestBilling;
        private System.Windows.Forms.Button btnRefreshre;
        private System.Windows.Forms.Button btnTestPtintRecept;
        private System.Windows.Forms.Button btnTestpay;
        private System.Windows.Forms.Button BackBtn;
    }
}