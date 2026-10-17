namespace Hospital_Management_System
{
    partial class AdTest
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
            this.pnltest1 = new System.Windows.Forms.Panel();
            this.txtTestCost = new System.Windows.Forms.TextBox();
            this.btntClear = new System.Windows.Forms.Button();
            this.btntdelete = new System.Windows.Forms.Button();
            this.btntestUpdate = new System.Windows.Forms.Button();
            this.txtNewTest = new System.Windows.Forms.TextBox();
            this.btntestBACK = new System.Windows.Forms.Button();
            this.btntestSAVE = new System.Windows.Forms.Button();
            this.lblNewTestCost = new System.Windows.Forms.Label();
            this.lblNewTest = new System.Windows.Forms.Label();
            this.txtTestID = new System.Windows.Forms.TextBox();
            this.lblTestName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTsearch = new System.Windows.Forms.Button();
            this.btntShowDetails = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dvgtestmanag = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnltest1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgtestmanag)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 85);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEST MANAGEMENT";
            // 
            // pnltest1
            // 
            this.pnltest1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnltest1.Controls.Add(this.txtTestCost);
            this.pnltest1.Controls.Add(this.btntClear);
            this.pnltest1.Controls.Add(this.btntdelete);
            this.pnltest1.Controls.Add(this.btntestUpdate);
            this.pnltest1.Controls.Add(this.txtNewTest);
            this.pnltest1.Controls.Add(this.btntestBACK);
            this.pnltest1.Controls.Add(this.btntestSAVE);
            this.pnltest1.Controls.Add(this.lblNewTestCost);
            this.pnltest1.Controls.Add(this.lblNewTest);
            this.pnltest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltest1.Location = new System.Drawing.Point(0, 82);
            this.pnltest1.Name = "pnltest1";
            this.pnltest1.Size = new System.Drawing.Size(728, 193);
            this.pnltest1.TabIndex = 3;
            // 
            // txtTestCost
            // 
            this.txtTestCost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTestCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestCost.Location = new System.Drawing.Point(224, 80);
            this.txtTestCost.Name = "txtTestCost";
            this.txtTestCost.Size = new System.Drawing.Size(113, 32);
            this.txtTestCost.TabIndex = 4;
            // 
            // btntClear
            // 
            this.btntClear.BackColor = System.Drawing.Color.GreenYellow;
            this.btntClear.Location = new System.Drawing.Point(454, 137);
            this.btntClear.Name = "btntClear";
            this.btntClear.Size = new System.Drawing.Size(103, 40);
            this.btntClear.TabIndex = 2;
            this.btntClear.Text = "Clear ";
            this.btntClear.UseVisualStyleBackColor = false;
            this.btntClear.Click += new System.EventHandler(this.btntClear_Click);
            // 
            // btntdelete
            // 
            this.btntdelete.BackColor = System.Drawing.Color.GreenYellow;
            this.btntdelete.Location = new System.Drawing.Point(327, 137);
            this.btntdelete.Name = "btntdelete";
            this.btntdelete.Size = new System.Drawing.Size(103, 40);
            this.btntdelete.TabIndex = 2;
            this.btntdelete.Text = "Delete";
            this.btntdelete.UseVisualStyleBackColor = false;
            this.btntdelete.Click += new System.EventHandler(this.btntdelete_Click);
            // 
            // btntestUpdate
            // 
            this.btntestUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btntestUpdate.Location = new System.Drawing.Point(180, 137);
            this.btntestUpdate.Name = "btntestUpdate";
            this.btntestUpdate.Size = new System.Drawing.Size(124, 40);
            this.btntestUpdate.TabIndex = 2;
            this.btntestUpdate.Text = "Update ";
            this.btntestUpdate.UseVisualStyleBackColor = false;
            this.btntestUpdate.Click += new System.EventHandler(this.btntestUpdate_Click);
            // 
            // txtNewTest
            // 
            this.txtNewTest.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNewTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewTest.Location = new System.Drawing.Point(210, 21);
            this.txtNewTest.Name = "txtNewTest";
            this.txtNewTest.Size = new System.Drawing.Size(254, 32);
            this.txtNewTest.TabIndex = 4;
            // 
            // btntestBACK
            // 
            this.btntestBACK.BackColor = System.Drawing.Color.LightCyan;
            this.btntestBACK.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btntestBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntestBACK.Location = new System.Drawing.Point(588, 150);
            this.btntestBACK.Name = "btntestBACK";
            this.btntestBACK.Size = new System.Drawing.Size(137, 40);
            this.btntestBACK.TabIndex = 3;
            this.btntestBACK.Text = "BACK";
            this.btntestBACK.UseVisualStyleBackColor = false;
            this.btntestBACK.Click += new System.EventHandler(this.btntestBACK_Click);
            // 
            // btntestSAVE
            // 
            this.btntestSAVE.BackColor = System.Drawing.Color.GreenYellow;
            this.btntestSAVE.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btntestSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntestSAVE.Location = new System.Drawing.Point(35, 137);
            this.btntestSAVE.Name = "btntestSAVE";
            this.btntestSAVE.Size = new System.Drawing.Size(123, 39);
            this.btntestSAVE.TabIndex = 1;
            this.btntestSAVE.Text = "SAVE";
            this.btntestSAVE.UseVisualStyleBackColor = false;
            this.btntestSAVE.Click += new System.EventHandler(this.btntestSAVE_Click);
            // 
            // lblNewTestCost
            // 
            this.lblNewTestCost.AutoSize = true;
            this.lblNewTestCost.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTestCost.Location = new System.Drawing.Point(71, 77);
            this.lblNewTestCost.Name = "lblNewTestCost";
            this.lblNewTestCost.Size = new System.Drawing.Size(133, 35);
            this.lblNewTestCost.TabIndex = 0;
            this.lblNewTestCost.Text = "Test Cost :";
            // 
            // lblNewTest
            // 
            this.lblNewTest.AutoSize = true;
            this.lblNewTest.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTest.Location = new System.Drawing.Point(59, 18);
            this.lblNewTest.Name = "lblNewTest";
            this.lblNewTest.Size = new System.Drawing.Size(145, 35);
            this.lblNewTest.TabIndex = 0;
            this.lblNewTest.Text = "Test Name:";
            // 
            // txtTestID
            // 
            this.txtTestID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestID.Location = new System.Drawing.Point(126, 10);
            this.txtTestID.Name = "txtTestID";
            this.txtTestID.Size = new System.Drawing.Size(113, 32);
            this.txtTestID.TabIndex = 4;
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(16, 7);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(104, 35);
            this.lblTestName.TabIndex = 0;
            this.lblTestName.Text = "Test Id :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.btnTsearch);
            this.panel2.Controls.Add(this.btntShowDetails);
            this.panel2.Controls.Add(this.txtTestID);
            this.panel2.Controls.Add(this.lblTestName);
            this.panel2.Location = new System.Drawing.Point(0, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 55);
            this.panel2.TabIndex = 4;
            // 
            // btnTsearch
            // 
            this.btnTsearch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTsearch.Location = new System.Drawing.Point(267, 10);
            this.btnTsearch.Name = "btnTsearch";
            this.btnTsearch.Size = new System.Drawing.Size(99, 38);
            this.btnTsearch.TabIndex = 6;
            this.btnTsearch.Text = "Search";
            this.btnTsearch.UseVisualStyleBackColor = true;
            this.btnTsearch.Click += new System.EventHandler(this.btnTsearch_Click);
            // 
            // btntShowDetails
            // 
            this.btntShowDetails.BackColor = System.Drawing.Color.SeaShell;
            this.btntShowDetails.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntShowDetails.Location = new System.Drawing.Point(561, 7);
            this.btntShowDetails.Name = "btntShowDetails";
            this.btntShowDetails.Size = new System.Drawing.Size(140, 41);
            this.btntShowDetails.TabIndex = 5;
            this.btntShowDetails.Text = "Show Details";
            this.btntShowDetails.UseVisualStyleBackColor = false;
            this.btntShowDetails.Click += new System.EventHandler(this.btntShowDetails_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dvgtestmanag);
            this.panel3.Location = new System.Drawing.Point(0, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 289);
            this.panel3.TabIndex = 5;
            // 
            // dvgtestmanag
            // 
            this.dvgtestmanag.AllowUserToAddRows = false;
            this.dvgtestmanag.AllowUserToDeleteRows = false;
            this.dvgtestmanag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgtestmanag.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgtestmanag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgtestmanag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgtestmanag.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dvgtestmanag.Location = new System.Drawing.Point(0, 0);
            this.dvgtestmanag.Name = "dvgtestmanag";
            this.dvgtestmanag.ReadOnly = true;
            this.dvgtestmanag.RowHeadersWidth = 62;
            this.dvgtestmanag.RowTemplate.Height = 28;
            this.dvgtestmanag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgtestmanag.Size = new System.Drawing.Size(728, 289);
            this.dvgtestmanag.TabIndex = 0;
            this.dvgtestmanag.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgtestmanag_CellContentClick);
            // 
            // AdTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 629);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnltest1);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "AdTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdTest";
            this.Load += new System.EventHandler(this.AdTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnltest1.ResumeLayout(false);
            this.pnltest1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgtestmanag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnltest1;
        private System.Windows.Forms.TextBox txtTestID;
        private System.Windows.Forms.TextBox txtTestCost;
        private System.Windows.Forms.TextBox txtNewTest;
        private System.Windows.Forms.Button btntestBACK;
        private System.Windows.Forms.Button btntestUpdate;
        private System.Windows.Forms.Button btntestSAVE;
        private System.Windows.Forms.Label lblNewTestCost;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblNewTest;
        private System.Windows.Forms.Button btntClear;
        private System.Windows.Forms.Button btntdelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btntShowDetails;
        private System.Windows.Forms.Button btnTsearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dvgtestmanag;
    }
}