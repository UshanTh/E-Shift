namespace E_Shift.Admin_Dashboard
{
    partial class ucUnit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJob_tbl = new System.Windows.Forms.DataGridView();
            this.btnUnit_Details = new System.Windows.Forms.Button();
            this.cmbUnit_status = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnit_id = new System.Windows.Forms.TextBox();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob_tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-3, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 2);
            this.panel1.TabIndex = 78;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnAssign.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnAssign.Location = new System.Drawing.Point(601, 599);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(181, 61);
            this.btnAssign.TabIndex = 69;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtDesc.Location = new System.Drawing.Point(39, 579);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(226, 81);
            this.txtDesc.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 24);
            this.label8.TabIndex = 76;
            this.label8.Text = "Description (Optional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 75;
            this.label7.Text = "Unit Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 70;
            this.label1.Text = "Transport Unit";
            // 
            // dgvJob_tbl
            // 
            this.dgvJob_tbl.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJob_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJob_tbl.Location = new System.Drawing.Point(601, 203);
            this.dgvJob_tbl.Name = "dgvJob_tbl";
            this.dgvJob_tbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvJob_tbl.RowTemplate.Height = 24;
            this.dgvJob_tbl.Size = new System.Drawing.Size(584, 377);
            this.dgvJob_tbl.TabIndex = 86;
            // 
            // btnUnit_Details
            // 
            this.btnUnit_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnUnit_Details.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnUnit_Details.Location = new System.Drawing.Point(1004, 599);
            this.btnUnit_Details.Name = "btnUnit_Details";
            this.btnUnit_Details.Size = new System.Drawing.Size(181, 61);
            this.btnUnit_Details.TabIndex = 87;
            this.btnUnit_Details.Text = "Unit Details";
            this.btnUnit_Details.UseVisualStyleBackColor = false;
            // 
            // cmbUnit_status
            // 
            this.cmbUnit_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit_status.Font = new System.Drawing.Font("Helvetica", 12F);
            this.cmbUnit_status.FormattingEnabled = true;
            this.cmbUnit_status.Items.AddRange(new object[] {
            "Ready",
            "Delivering",
            "Delivered"});
            this.cmbUnit_status.Location = new System.Drawing.Point(39, 460);
            this.cmbUnit_status.Name = "cmbUnit_status";
            this.cmbUnit_status.Size = new System.Drawing.Size(222, 32);
            this.cmbUnit_status.TabIndex = 132;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnSave.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnSave.Location = new System.Drawing.Point(800, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 61);
            this.btnSave.TabIndex = 133;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "Unit Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 74;
            this.label6.Text = "Job ID";
            // 
            // txtUnit_id
            // 
            this.txtUnit_id.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtUnit_id.Location = new System.Drawing.Point(39, 227);
            this.txtUnit_id.Name = "txtUnit_id";
            this.txtUnit_id.ReadOnly = true;
            this.txtUnit_id.Size = new System.Drawing.Size(226, 31);
            this.txtUnit_id.TabIndex = 62;
            // 
            // txtJobId
            // 
            this.txtJobId.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtJobId.Location = new System.Drawing.Point(39, 336);
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.Size = new System.Drawing.Size(226, 31);
            this.txtJobId.TabIndex = 64;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Helvetica", 12F);
            this.textBox1.Location = new System.Drawing.Point(327, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 31);
            this.textBox1.TabIndex = 135;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Helvetica", 12F);
            this.textBox2.Location = new System.Drawing.Point(327, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 31);
            this.textBox2.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 137;
            this.label3.Text = "Assistant ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 136;
            this.label4.Text = "Driver ID";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Helvetica", 12F);
            this.textBox3.Location = new System.Drawing.Point(327, 579);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 31);
            this.textBox3.TabIndex = 139;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Helvetica", 12F);
            this.textBox4.Location = new System.Drawing.Point(327, 461);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 31);
            this.textBox4.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 141;
            this.label5.Text = "Cont.ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(327, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 140;
            this.label9.Text = "Lorry ID";
            // 
            // ucUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbUnit_status);
            this.Controls.Add(this.btnUnit_Details);
            this.Controls.Add(this.dgvJob_tbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.txtUnit_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucUnit";
            this.Size = new System.Drawing.Size(1242, 748);
            this.Load += new System.EventHandler(this.ucUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob_tbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvJob_tbl;
        private System.Windows.Forms.Button btnUnit_Details;
        private System.Windows.Forms.ComboBox cmbUnit_status;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnit_id;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}
