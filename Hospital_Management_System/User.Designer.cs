namespace Hospital_Management_System
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnuucSERCH = new System.Windows.Forms.Button();
            this.btnseUserUD = new System.Windows.Forms.Label();
            this.txtseucUSERID = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtUserSl = new System.Windows.Forms.TextBox();
            this.lblucUserSl = new System.Windows.Forms.Label();
            this.btnuserDelete = new System.Windows.Forms.Button();
            this.txtucPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnucBACK = new System.Windows.Forms.Button();
            this.btnuserUpdate = new System.Windows.Forms.Button();
            this.btnuserSave = new System.Windows.Forms.Button();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblucpassword = new System.Windows.Forms.Label();
            this.lblucUserID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUcClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUcShowDetails = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.userControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControlBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(635, 281);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 31);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnuucSERCH
            // 
            this.btnuucSERCH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnuucSERCH.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuucSERCH.Location = new System.Drawing.Point(369, 284);
            this.btnuucSERCH.Name = "btnuucSERCH";
            this.btnuucSERCH.Size = new System.Drawing.Size(108, 31);
            this.btnuucSERCH.TabIndex = 13;
            this.btnuucSERCH.Text = "SERCH";
            this.btnuucSERCH.UseVisualStyleBackColor = false;
            this.btnuucSERCH.Click += new System.EventHandler(this.btnuucSERCH_Click);
            // 
            // btnseUserUD
            // 
            this.btnseUserUD.AutoSize = true;
            this.btnseUserUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseUserUD.Location = new System.Drawing.Point(81, 290);
            this.btnseUserUD.Name = "btnseUserUD";
            this.btnseUserUD.Size = new System.Drawing.Size(89, 22);
            this.btnseUserUD.TabIndex = 12;
            this.btnseUserUD.Text = "USER ID";
            // 
            // txtseucUSERID
            // 
            this.txtseucUSERID.Location = new System.Drawing.Point(211, 289);
            this.txtseucUSERID.Name = "txtseucUSERID";
            this.txtseucUSERID.Size = new System.Drawing.Size(115, 26);
            this.txtseucUSERID.TabIndex = 11;
            // 
            // txtUserSl
            // 
            this.txtUserSl.Location = new System.Drawing.Point(536, 61);
            this.txtUserSl.Name = "txtUserSl";
            this.txtUserSl.Size = new System.Drawing.Size(146, 37);
            this.txtUserSl.TabIndex = 6;
            // 
            // lblucUserSl
            // 
            this.lblucUserSl.AutoSize = true;
            this.lblucUserSl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblucUserSl.Location = new System.Drawing.Point(409, 59);
            this.lblucUserSl.Name = "lblucUserSl";
            this.lblucUserSl.Size = new System.Drawing.Size(106, 29);
            this.lblucUserSl.TabIndex = 5;
            this.lblucUserSl.Text = "User No :";
            // 
            // btnuserDelete
            // 
            this.btnuserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnuserDelete.Location = new System.Drawing.Point(545, 131);
            this.btnuserDelete.Name = "btnuserDelete";
            this.btnuserDelete.Size = new System.Drawing.Size(124, 51);
            this.btnuserDelete.TabIndex = 4;
            this.btnuserDelete.Text = "Delete ";
            this.btnuserDelete.UseVisualStyleBackColor = false;
            this.btnuserDelete.Click += new System.EventHandler(this.btnuserDelete_Click);
            // 
            // txtucPassword
            // 
            this.txtucPassword.Location = new System.Drawing.Point(211, 58);
            this.txtucPassword.Name = "txtucPassword";
            this.txtucPassword.Size = new System.Drawing.Size(162, 37);
            this.txtucPassword.TabIndex = 3;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(211, 8);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(162, 37);
            this.txtUserID.TabIndex = 3;
            // 
            // btnucBACK
            // 
            this.btnucBACK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnucBACK.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnucBACK.Location = new System.Drawing.Point(835, 146);
            this.btnucBACK.Name = "btnucBACK";
            this.btnucBACK.Size = new System.Drawing.Size(104, 52);
            this.btnucBACK.TabIndex = 2;
            this.btnucBACK.Text = "BACK";
            this.btnucBACK.UseVisualStyleBackColor = false;
            this.btnucBACK.Click += new System.EventHandler(this.btnucBACK_Click);
            // 
            // btnuserUpdate
            // 
            this.btnuserUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnuserUpdate.Location = new System.Drawing.Point(399, 130);
            this.btnuserUpdate.Name = "btnuserUpdate";
            this.btnuserUpdate.Size = new System.Drawing.Size(118, 52);
            this.btnuserUpdate.TabIndex = 2;
            this.btnuserUpdate.Text = "Update";
            this.btnuserUpdate.UseVisualStyleBackColor = false;
            this.btnuserUpdate.Click += new System.EventHandler(this.btnuserUpdate_Click);
            // 
            // btnuserSave
            // 
            this.btnuserSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnuserSave.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserSave.Location = new System.Drawing.Point(267, 132);
            this.btnuserSave.Name = "btnuserSave";
            this.btnuserSave.Size = new System.Drawing.Size(110, 50);
            this.btnuserSave.TabIndex = 2;
            this.btnuserSave.Text = "Save";
            this.btnuserSave.UseVisualStyleBackColor = false;
            this.btnuserSave.Click += new System.EventHandler(this.btnuserSave_Click);
            // 
            // cmbUserType
            // 
            this.cmbUserType.BackColor = System.Drawing.SystemColors.Info;
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Receptionist"});
            this.cmbUserType.Location = new System.Drawing.Point(536, 8);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(146, 37);
            this.cmbUserType.TabIndex = 1;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(406, 8);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(134, 26);
            this.lblUserType.TabIndex = 0;
            this.lblUserType.Text = "User Type :";
            // 
            // lblucpassword
            // 
            this.lblucpassword.AutoSize = true;
            this.lblucpassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblucpassword.Location = new System.Drawing.Point(72, 61);
            this.lblucpassword.Name = "lblucpassword";
            this.lblucpassword.Size = new System.Drawing.Size(123, 29);
            this.lblucpassword.TabIndex = 0;
            this.lblucpassword.Text = "Password :";
            // 
            // lblucUserID
            // 
            this.lblucUserID.AutoSize = true;
            this.lblucUserID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblucUserID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblucUserID.Location = new System.Drawing.Point(72, 11);
            this.lblucUserID.Name = "lblucUserID";
            this.lblucUserID.Size = new System.Drawing.Size(98, 29);
            this.lblucUserID.TabIndex = 0;
            this.lblucUserID.Text = "User ID :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnUcClear);
            this.panel2.Controls.Add(this.txtUserSl);
            this.panel2.Controls.Add(this.lblucUserSl);
            this.panel2.Controls.Add(this.btnuserDelete);
            this.panel2.Controls.Add(this.txtucPassword);
            this.panel2.Controls.Add(this.txtUserID);
            this.panel2.Controls.Add(this.btnucBACK);
            this.panel2.Controls.Add(this.btnuserUpdate);
            this.panel2.Controls.Add(this.btnuserSave);
            this.panel2.Controls.Add(this.cmbUserType);
            this.panel2.Controls.Add(this.lblUserType);
            this.panel2.Controls.Add(this.lblucpassword);
            this.panel2.Controls.Add(this.lblucUserID);
            this.panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 211);
            this.panel2.TabIndex = 10;
            // 
            // btnUcClear
            // 
            this.btnUcClear.Location = new System.Drawing.Point(696, 132);
            this.btnUcClear.Name = "btnUcClear";
            this.btnUcClear.Size = new System.Drawing.Size(106, 52);
            this.btnUcClear.TabIndex = 7;
            this.btnUcClear.Text = "Clear";
            this.btnUcClear.UseVisualStyleBackColor = true;
            this.btnUcClear.Click += new System.EventHandler(this.btnUcClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Control";
            // 
            // btnUcShowDetails
            // 
            this.btnUcShowDetails.Location = new System.Drawing.Point(764, 283);
            this.btnUcShowDetails.Name = "btnUcShowDetails";
            this.btnUcShowDetails.Size = new System.Drawing.Size(175, 32);
            this.btnUcShowDetails.TabIndex = 14;
            this.btnUcShowDetails.Text = "Show Details";
            this.btnUcShowDetails.UseVisualStyleBackColor = true;
            this.btnUcShowDetails.Click += new System.EventHandler(this.btnUcShowDetails_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.DataSource = this.userControlBindingSource;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsers.Location = new System.Drawing.Point(0, 321);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(950, 305);
            this.dgvUsers.TabIndex = 9;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // userControlBindingSource
            // 
            this.userControlBindingSource.DataMember = "User_Control";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 73);
            this.panel1.TabIndex = 8;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 626);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnuucSERCH);
            this.Controls.Add(this.btnseUserUD);
            this.Controls.Add(this.txtseucUSERID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUcShowDetails);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControlBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnuucSERCH;
        private System.Windows.Forms.Label btnseUserUD;
        private System.Windows.Forms.TextBox txtseucUSERID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtUserSl;
        private System.Windows.Forms.Label lblucUserSl;
        private System.Windows.Forms.Button btnuserDelete;
        private System.Windows.Forms.TextBox txtucPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnucBACK;
        private System.Windows.Forms.Button btnuserUpdate;
        private System.Windows.Forms.Button btnuserSave;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblucpassword;
        private System.Windows.Forms.Label lblucUserID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource userControlBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUcShowDetails;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUcClear;
    }
}