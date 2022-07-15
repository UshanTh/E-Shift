namespace E_Shift.Admin_Dashboard
{
    partial class ucJob_details
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUsr_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvJob_tbl = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartime = new System.Windows.Forms.DateTimePicker();
            this.dtpStrtdate = new System.Windows.Forms.DateTimePicker();
            this.dtpEnddate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndtime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbJob_status = new System.Windows.Forms.ComboBox();
            this.txtCus_status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCus_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnd_location = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStart_location = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob_tbl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsr_id
            // 
            this.txtUsr_id.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtUsr_id.Location = new System.Drawing.Point(45, 188);
            this.txtUsr_id.Name = "txtUsr_id";
            this.txtUsr_id.Size = new System.Drawing.Size(206, 31);
            this.txtUsr_id.TabIndex = 64;
            this.txtUsr_id.Leave += new System.EventHandler(this.txtUsr_id_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 65;
            this.label10.Text = "Customer Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 2);
            this.panel1.TabIndex = 61;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnAdd.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnAdd.Location = new System.Drawing.Point(533, 644);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 73);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Manage Jobs";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnSave.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnSave.Location = new System.Drawing.Point(982, 644);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 73);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvJob_tbl
            // 
            this.dgvJob_tbl.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJob_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJob_tbl.Location = new System.Drawing.Point(533, 232);
            this.dgvJob_tbl.Name = "dgvJob_tbl";
            this.dgvJob_tbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvJob_tbl.RowTemplate.Height = 24;
            this.dgvJob_tbl.Size = new System.Drawing.Size(635, 366);
            this.dgvJob_tbl.TabIndex = 85;
            this.dgvJob_tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJob_tbl_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 87;
            this.label4.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 86;
            this.label5.Text = "Start TIme";
            // 
            // dtpStartime
            // 
            this.dtpStartime.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtpStartime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartime.Location = new System.Drawing.Point(45, 472);
            this.dtpStartime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartime.Name = "dtpStartime";
            this.dtpStartime.ShowUpDown = true;
            this.dtpStartime.Size = new System.Drawing.Size(206, 34);
            this.dtpStartime.TabIndex = 117;
            this.dtpStartime.Value = new System.DateTime(2020, 3, 22, 1, 0, 0, 0);
            // 
            // dtpStrtdate
            // 
            this.dtpStrtdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtpStrtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStrtdate.Location = new System.Drawing.Point(45, 275);
            this.dtpStrtdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStrtdate.Name = "dtpStrtdate";
            this.dtpStrtdate.Size = new System.Drawing.Size(206, 34);
            this.dtpStrtdate.TabIndex = 119;
            this.dtpStrtdate.Value = new System.DateTime(2022, 7, 16, 0, 0, 0, 0);
            // 
            // dtpEnddate
            // 
            this.dtpEnddate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtpEnddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnddate.Location = new System.Drawing.Point(45, 374);
            this.dtpEnddate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnddate.Name = "dtpEnddate";
            this.dtpEnddate.Size = new System.Drawing.Size(206, 34);
            this.dtpEnddate.TabIndex = 120;
            this.dtpEnddate.Value = new System.DateTime(2022, 7, 16, 0, 0, 0, 0);
            // 
            // dtpEndtime
            // 
            this.dtpEndtime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpEndtime.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtpEndtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndtime.Location = new System.Drawing.Point(45, 574);
            this.dtpEndtime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndtime.Name = "dtpEndtime";
            this.dtpEndtime.ShowUpDown = true;
            this.dtpEndtime.Size = new System.Drawing.Size(206, 34);
            this.dtpEndtime.TabIndex = 121;
            this.dtpEndtime.Value = new System.DateTime(2020, 3, 22, 1, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.cmbJob_status);
            this.groupBox1.Controls.Add(this.txtCus_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCus_Name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEnd_location);
            this.groupBox1.Font = new System.Drawing.Font("Helvetica", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(298, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 564);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // cmbJob_status
            // 
            this.cmbJob_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJob_status.Font = new System.Drawing.Font("Helvetica", 12F);
            this.cmbJob_status.FormattingEnabled = true;
            this.cmbJob_status.Items.AddRange(new object[] {
            "Approved",
            "Decline"});
            this.cmbJob_status.Location = new System.Drawing.Point(6, 359);
            this.cmbJob_status.Name = "cmbJob_status";
            this.cmbJob_status.Size = new System.Drawing.Size(200, 32);
            this.cmbJob_status.TabIndex = 131;
            // 
            // txtCus_status
            // 
            this.txtCus_status.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtCus_status.Location = new System.Drawing.Point(6, 225);
            this.txtCus_status.Name = "txtCus_status";
            this.txtCus_status.ReadOnly = true;
            this.txtCus_status.Size = new System.Drawing.Size(206, 31);
            this.txtCus_status.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 130;
            this.label3.Text = "Job Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 24);
            this.label11.TabIndex = 77;
            this.label11.Text = "Customer Status";
            // 
            // txtCus_Name
            // 
            this.txtCus_Name.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtCus_Name.Location = new System.Drawing.Point(6, 119);
            this.txtCus_Name.Name = "txtCus_Name";
            this.txtCus_Name.ReadOnly = true;
            this.txtCus_Name.Size = new System.Drawing.Size(206, 31);
            this.txtCus_Name.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 75;
            this.label9.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 73;
            this.label8.Text = "End Location";
            // 
            // txtEnd_location
            // 
            this.txtEnd_location.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtEnd_location.Location = new System.Drawing.Point(6, 456);
            this.txtEnd_location.Name = "txtEnd_location";
            this.txtEnd_location.Size = new System.Drawing.Size(206, 31);
            this.txtEnd_location.TabIndex = 71;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtId.Location = new System.Drawing.Point(775, 187);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 31);
            this.txtId.TabIndex = 123;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnFind.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnFind.Location = new System.Drawing.Point(1024, 176);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(144, 51);
            this.btnFind.TabIndex = 126;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnClear.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnClear.Location = new System.Drawing.Point(754, 644);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(188, 73);
            this.btnClear.TabIndex = 127;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.Font = new System.Drawing.Font("Helvetica", 12F);
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "JOB ID",
            "Customer ID"});
            this.cmbSearchBy.Location = new System.Drawing.Point(548, 187);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(200, 32);
            this.cmbSearchBy.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(547, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 24);
            this.label12.TabIndex = 128;
            this.label12.Text = "Search By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(45, 644);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 72;
            this.label7.Text = "Start Location";
            // 
            // txtStart_location
            // 
            this.txtStart_location.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtStart_location.Location = new System.Drawing.Point(45, 686);
            this.txtStart_location.Name = "txtStart_location";
            this.txtStart_location.Size = new System.Drawing.Size(206, 31);
            this.txtStart_location.TabIndex = 70;
            // 
            // ucJob_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStart_location);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpEndtime);
            this.Controls.Add(this.dtpEnddate);
            this.Controls.Add(this.dtpStrtdate);
            this.Controls.Add(this.dtpStartime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvJob_tbl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUsr_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucJob_details";
            this.Size = new System.Drawing.Size(1242, 748);
            this.Load += new System.EventHandler(this.ucJob_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob_tbl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsr_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvJob_tbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartime;
        private System.Windows.Forms.DateTimePicker dtpStrtdate;
        private System.Windows.Forms.DateTimePicker dtpEnddate;
        private System.Windows.Forms.DateTimePicker dtpEndtime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCus_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCus_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStart_location;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnd_location;
        private System.Windows.Forms.ComboBox cmbJob_status;
        private System.Windows.Forms.Label label3;
    }
}
