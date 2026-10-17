namespace Hospital_Management_System
{
    partial class AdRoom
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
            this.btnadroom = new System.Windows.Forms.Button();
            this.btnrRmClear = new System.Windows.Forms.Button();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.btnRoomsave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbadroomstatus = new System.Windows.Forms.ComboBox();
            this.cmbAdRoomType = new System.Windows.Forms.ComboBox();
            this.txtAdrmCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textadRoomId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRoomShow = new System.Windows.Forms.Button();
            this.btnrmSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dvgRoomManagment = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRoomManagment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(129, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROOM Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btnadroom);
            this.panel2.Controls.Add(this.btnrRmClear);
            this.panel2.Controls.Add(this.btnRoomDelete);
            this.panel2.Controls.Add(this.btnRoomUpdate);
            this.panel2.Controls.Add(this.btnRoomsave);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbadroomstatus);
            this.panel2.Controls.Add(this.cmbAdRoomType);
            this.panel2.Controls.Add(this.txtAdrmCost);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 228);
            this.panel2.TabIndex = 2;
            // 
            // btnadroom
            // 
            this.btnadroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadroom.Location = new System.Drawing.Point(663, 179);
            this.btnadroom.Name = "btnadroom";
            this.btnadroom.Size = new System.Drawing.Size(109, 46);
            this.btnadroom.TabIndex = 11;
            this.btnadroom.Text = "Back";
            this.btnadroom.UseVisualStyleBackColor = true;
            this.btnadroom.Click += new System.EventHandler(this.btnadroom_Click);
            // 
            // btnrRmClear
            // 
            this.btnrRmClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrRmClear.Location = new System.Drawing.Point(496, 162);
            this.btnrRmClear.Name = "btnrRmClear";
            this.btnrRmClear.Size = new System.Drawing.Size(133, 46);
            this.btnrRmClear.TabIndex = 10;
            this.btnrRmClear.Text = "Clear";
            this.btnrRmClear.UseVisualStyleBackColor = true;
            this.btnrRmClear.Click += new System.EventHandler(this.btnrRmClear_Click);
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDelete.Location = new System.Drawing.Point(341, 162);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(149, 46);
            this.btnRoomDelete.TabIndex = 10;
            this.btnRoomDelete.Text = "Delete";
            this.btnRoomDelete.UseVisualStyleBackColor = true;
            this.btnRoomDelete.Click += new System.EventHandler(this.btnRoomDelete_Click);
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomUpdate.Location = new System.Drawing.Point(192, 162);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(130, 46);
            this.btnRoomUpdate.TabIndex = 10;
            this.btnRoomUpdate.Text = "Update";
            this.btnRoomUpdate.UseVisualStyleBackColor = true;
            this.btnRoomUpdate.Click += new System.EventHandler(this.btnRoomUpdate_Click);
            // 
            // btnRoomsave
            // 
            this.btnRoomsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomsave.Location = new System.Drawing.Point(35, 162);
            this.btnRoomsave.Name = "btnRoomsave";
            this.btnRoomsave.Size = new System.Drawing.Size(123, 46);
            this.btnRoomsave.TabIndex = 10;
            this.btnRoomsave.Text = "Save";
            this.btnRoomsave.UseVisualStyleBackColor = true;
            this.btnRoomsave.Click += new System.EventHandler(this.btnRoomsave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "ROOM Quantity :";
            // 
            // cmbadroomstatus
            // 
            this.cmbadroomstatus.FormattingEnabled = true;
            this.cmbadroomstatus.Items.AddRange(new object[] {
            "",
            "15",
            "20",
            "30",
            "50",
            "100"});
            this.cmbadroomstatus.Location = new System.Drawing.Point(546, 91);
            this.cmbadroomstatus.Name = "cmbadroomstatus";
            this.cmbadroomstatus.Size = new System.Drawing.Size(121, 28);
            this.cmbadroomstatus.TabIndex = 8;
            // 
            // cmbAdRoomType
            // 
            this.cmbAdRoomType.FormattingEnabled = true;
            this.cmbAdRoomType.Items.AddRange(new object[] {
            "General World",
            "ICU",
            "PRIVATE"});
            this.cmbAdRoomType.Location = new System.Drawing.Point(250, 25);
            this.cmbAdRoomType.Name = "cmbAdRoomType";
            this.cmbAdRoomType.Size = new System.Drawing.Size(170, 28);
            this.cmbAdRoomType.TabIndex = 8;
            // 
            // txtAdrmCost
            // 
            this.txtAdrmCost.Location = new System.Drawing.Point(203, 95);
            this.txtAdrmCost.Name = "txtAdrmCost";
            this.txtAdrmCost.Size = new System.Drawing.Size(94, 26);
            this.txtAdrmCost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(110, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "COST :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(91, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ROOM TYPE :";
            // 
            // textadRoomId
            // 
            this.textadRoomId.Location = new System.Drawing.Point(139, 5);
            this.textadRoomId.Name = "textadRoomId";
            this.textadRoomId.Size = new System.Drawing.Size(93, 26);
            this.textadRoomId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "ROOM ID :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.btnRoomShow);
            this.panel3.Controls.Add(this.btnrmSearch);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textadRoomId);
            this.panel3.Location = new System.Drawing.Point(0, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 40);
            this.panel3.TabIndex = 3;
            // 
            // btnRoomShow
            // 
            this.btnRoomShow.Location = new System.Drawing.Point(628, 4);
            this.btnRoomShow.Name = "btnRoomShow";
            this.btnRoomShow.Size = new System.Drawing.Size(134, 36);
            this.btnRoomShow.TabIndex = 8;
            this.btnRoomShow.Text = "Show Details";
            this.btnRoomShow.UseVisualStyleBackColor = true;
            this.btnRoomShow.Click += new System.EventHandler(this.btnRoomShow_Click);
            // 
            // btnrmSearch
            // 
            this.btnrmSearch.Location = new System.Drawing.Point(264, 4);
            this.btnrmSearch.Name = "btnrmSearch";
            this.btnrmSearch.Size = new System.Drawing.Size(102, 29);
            this.btnrmSearch.TabIndex = 7;
            this.btnrmSearch.Text = "Search";
            this.btnrmSearch.UseVisualStyleBackColor = true;
            this.btnrmSearch.Click += new System.EventHandler(this.btnrmSearch_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 230);
            this.panel4.TabIndex = 4;
            // 
            // dvgRoomManagment
            // 
            this.dvgRoomManagment.AllowUserToAddRows = false;
            this.dvgRoomManagment.AllowUserToDeleteRows = false;
            this.dvgRoomManagment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgRoomManagment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgRoomManagment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRoomManagment.Location = new System.Drawing.Point(3, 376);
            this.dvgRoomManagment.Name = "dvgRoomManagment";
            this.dvgRoomManagment.ReadOnly = true;
            this.dvgRoomManagment.RowHeadersWidth = 62;
            this.dvgRoomManagment.RowTemplate.Height = 28;
            this.dvgRoomManagment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgRoomManagment.Size = new System.Drawing.Size(769, 230);
            this.dvgRoomManagment.TabIndex = 4;
            this.dvgRoomManagment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgRoomManagment_CellContentClick);
            // 
            // AdRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 608);
            this.Controls.Add(this.dvgRoomManagment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdRoom";
            this.Load += new System.EventHandler(this.AdRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRoomManagment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbAdRoomType;
        private System.Windows.Forms.TextBox txtAdrmCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textadRoomId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbadroomstatus;
        private System.Windows.Forms.Button btnadroom;
        private System.Windows.Forms.Button btnRoomsave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnrRmClear;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dvgRoomManagment;
        private System.Windows.Forms.Button btnRoomShow;
        private System.Windows.Forms.Button btnrmSearch;
    }
}