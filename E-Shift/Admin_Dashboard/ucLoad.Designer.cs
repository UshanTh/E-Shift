namespace E_Shift.Admin_Dashboard
{
    partial class ucLoad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbLoad_status = new System.Windows.Forms.ComboBox();
            this.dgvLoad_tbl = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtUnit_ID = new System.Windows.Forms.TextBox();
            this.txtLoad_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJob_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvjob_Product_load = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoad_tbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjob_Product_load)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnSave.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnSave.Location = new System.Drawing.Point(855, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 61);
            this.btnSave.TabIndex = 147;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbLoad_status
            // 
            this.cmbLoad_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoad_status.Font = new System.Drawing.Font("Helvetica", 12F);
            this.cmbLoad_status.FormattingEnabled = true;
            this.cmbLoad_status.Items.AddRange(new object[] {
            "Packing",
            "Ready"});
            this.cmbLoad_status.Location = new System.Drawing.Point(63, 500);
            this.cmbLoad_status.Name = "cmbLoad_status";
            this.cmbLoad_status.Size = new System.Drawing.Size(413, 32);
            this.cmbLoad_status.TabIndex = 146;
            // 
            // dgvLoad_tbl
            // 
            this.dgvLoad_tbl.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLoad_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoad_tbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoad_tbl.Location = new System.Drawing.Point(533, 390);
            this.dgvLoad_tbl.Name = "dgvLoad_tbl";
            this.dgvLoad_tbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLoad_tbl.RowTemplate.Height = 24;
            this.dgvLoad_tbl.Size = new System.Drawing.Size(635, 175);
            this.dgvLoad_tbl.TabIndex = 144;
            this.dgvLoad_tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoad_tbl_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 2);
            this.panel1.TabIndex = 143;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnAssign.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnAssign.Location = new System.Drawing.Point(533, 599);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(157, 61);
            this.btnAssign.TabIndex = 137;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtDesc.Location = new System.Drawing.Point(63, 599);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(417, 61);
            this.txtDesc.TabIndex = 136;
            // 
            // txtUnit_ID
            // 
            this.txtUnit_ID.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtUnit_ID.Location = new System.Drawing.Point(63, 324);
            this.txtUnit_ID.Name = "txtUnit_ID";
            this.txtUnit_ID.Size = new System.Drawing.Size(417, 31);
            this.txtUnit_ID.TabIndex = 135;
            // 
            // txtLoad_id
            // 
            this.txtLoad_id.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtLoad_id.Location = new System.Drawing.Point(63, 227);
            this.txtLoad_id.Name = "txtLoad_id";
            this.txtLoad_id.Size = new System.Drawing.Size(417, 31);
            this.txtLoad_id.TabIndex = 134;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 24);
            this.label8.TabIndex = 142;
            this.label8.Text = "Description (Optional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 141;
            this.label7.Text = "Load Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 140;
            this.label6.Text = "Unit iD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 139;
            this.label2.Text = "Load Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 138;
            this.label1.Text = "Manage Load";
            // 
            // txtJob_ID
            // 
            this.txtJob_ID.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtJob_ID.Location = new System.Drawing.Point(63, 413);
            this.txtJob_ID.Name = "txtJob_ID";
            this.txtJob_ID.Size = new System.Drawing.Size(417, 31);
            this.txtJob_ID.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 149;
            this.label3.Text = "Job iD";
            // 
            // dgvjob_Product_load
            // 
            this.dgvjob_Product_load.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvjob_Product_load.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvjob_Product_load.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvjob_Product_load.Location = new System.Drawing.Point(533, 188);
            this.dgvjob_Product_load.Name = "dgvjob_Product_load";
            this.dgvjob_Product_load.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvjob_Product_load.RowTemplate.Height = 24;
            this.dgvjob_Product_load.Size = new System.Drawing.Size(635, 175);
            this.dgvjob_Product_load.TabIndex = 150;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnSearch.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnSearch.Location = new System.Drawing.Point(694, 599);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 61);
            this.btnSearch.TabIndex = 151;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnClear.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnClear.Location = new System.Drawing.Point(1013, 599);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 61);
            this.btnClear.TabIndex = 152;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ucLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvjob_Product_load);
            this.Controls.Add(this.txtJob_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbLoad_status);
            this.Controls.Add(this.dgvLoad_tbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtUnit_ID);
            this.Controls.Add(this.txtLoad_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucLoad";
            this.Size = new System.Drawing.Size(1242, 748);
            this.Load += new System.EventHandler(this.ucLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoad_tbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjob_Product_load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbLoad_status;
        private System.Windows.Forms.DataGridView dgvLoad_tbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtUnit_ID;
        private System.Windows.Forms.TextBox txtLoad_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJob_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvjob_Product_load;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}
