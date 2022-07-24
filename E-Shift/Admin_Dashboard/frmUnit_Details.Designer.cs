namespace E_Shift.Admin_Dashboard
{
    partial class frmUnit_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit_Details));
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgv_Unit = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbUnit_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Unit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnSearch.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnSearch.Location = new System.Drawing.Point(537, 154);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 54);
            this.btnSearch.TabIndex = 169;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgv_Unit
            // 
            this.dgv_Unit.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Unit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Unit.Location = new System.Drawing.Point(54, 275);
            this.dgv_Unit.Name = "dgv_Unit";
            this.dgv_Unit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_Unit.RowTemplate.Height = 24;
            this.dgv_Unit.Size = new System.Drawing.Size(915, 364);
            this.dgv_Unit.TabIndex = 168;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtID.Location = new System.Drawing.Point(328, 177);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(189, 31);
            this.txtID.TabIndex = 154;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 167;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-9, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 2);
            this.panel1.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 159;
            this.label1.Text = "Unit Details";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnSave.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnSave.Location = new System.Drawing.Point(786, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 54);
            this.btnSave.TabIndex = 172;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbUnit_status
            // 
            this.cmbUnit_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit_status.Font = new System.Drawing.Font("Helvetica", 12F);
            this.cmbUnit_status.FormattingEnabled = true;
            this.cmbUnit_status.Items.AddRange(new object[] {
            "Delivering",
            "Delivered"});
            this.cmbUnit_status.Location = new System.Drawing.Point(736, 168);
            this.cmbUnit_status.Name = "cmbUnit_status";
            this.cmbUnit_status.Size = new System.Drawing.Size(233, 32);
            this.cmbUnit_status.TabIndex = 171;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(782, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 170;
            this.label2.Text = "Update Status";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.Font = new System.Drawing.Font("Helvetica", 12F);
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "JOB ID",
            "UNIT ID"});
            this.cmbSearchBy.Location = new System.Drawing.Point(54, 177);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(213, 32);
            this.cmbSearchBy.TabIndex = 174;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 173;
            this.label7.Text = "Search By";
            // 
            // frmUnit_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 701);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbUnit_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgv_Unit);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUnit_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Details";
            this.Load += new System.EventHandler(this.frmUnit_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Unit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgv_Unit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbUnit_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label label7;
    }
}