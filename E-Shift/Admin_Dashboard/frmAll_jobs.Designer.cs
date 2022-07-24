namespace E_Shift.Admin_Dashboard
{
    partial class frmAll_jobs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAll_jobs));
            this.dgvJob_tbl = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob_tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJob_tbl
            // 
            this.dgvJob_tbl.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJob_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJob_tbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJob_tbl.Location = new System.Drawing.Point(36, 210);
            this.dgvJob_tbl.Name = "dgvJob_tbl";
            this.dgvJob_tbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvJob_tbl.RowTemplate.Height = 24;
            this.dgvJob_tbl.Size = new System.Drawing.Size(992, 385);
            this.dgvJob_tbl.TabIndex = 145;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-9, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 2);
            this.panel1.TabIndex = 144;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnFind.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnFind.Location = new System.Drawing.Point(427, 130);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 46);
            this.btnFind.TabIndex = 139;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 140;
            this.label1.Text = "Job Details";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txt_Id.Location = new System.Drawing.Point(182, 142);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(220, 31);
            this.txt_Id.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 147;
            this.label2.Text = "Enter Job ID: ";
            // 
            // frmAll_jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.dgvJob_tbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAll_jobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Details";
            this.Load += new System.EventHandler(this.frmAll_jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob_tbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvJob_tbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
    }
}