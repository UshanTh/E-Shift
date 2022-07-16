namespace E_Shift.Admin_Dashboard
{
    partial class ucCustomer_details
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
            this.dgvCustomerTbl = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCus_Status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCus_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerTbl
            // 
            this.dgvCustomerTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerTbl.Location = new System.Drawing.Point(61, 269);
            this.dgvCustomerTbl.Name = "dgvCustomerTbl";
            this.dgvCustomerTbl.RowTemplate.Height = 24;
            this.dgvCustomerTbl.Size = new System.Drawing.Size(1105, 434);
            this.dgvCustomerTbl.TabIndex = 102;
            this.dgvCustomerTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerTbl_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 2);
            this.panel1.TabIndex = 101;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtFname.Location = new System.Drawing.Point(61, 205);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(250, 31);
            this.txtFname.TabIndex = 89;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 96;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 33);
            this.label1.TabIndex = 91;
            this.label1.Text = "Customer Information";
            // 
            // cmbCus_Status
            // 
            this.cmbCus_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCus_Status.Font = new System.Drawing.Font("Helvetica", 12F);
            this.cmbCus_Status.FormattingEnabled = true;
            this.cmbCus_Status.Items.AddRange(new object[] {
            "Approved",
            "Decline"});
            this.cmbCus_Status.Location = new System.Drawing.Point(719, 205);
            this.cmbCus_Status.Name = "cmbCus_Status";
            this.cmbCus_Status.Size = new System.Drawing.Size(233, 32);
            this.cmbCus_Status.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(719, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 132;
            this.label3.Text = "Update Status";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnSave.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnSave.Location = new System.Drawing.Point(1009, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 44);
            this.btnSave.TabIndex = 134;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCus_ID
            // 
            this.txtCus_ID.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtCus_ID.Location = new System.Drawing.Point(379, 206);
            this.txtCus_ID.Name = "txtCus_ID";
            this.txtCus_ID.ReadOnly = true;
            this.txtCus_ID.Size = new System.Drawing.Size(250, 31);
            this.txtCus_ID.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 136;
            this.label4.Text = "Customer ID";
            // 
            // ucCustomer_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCus_ID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCus_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCustomerTbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucCustomer_details";
            this.Size = new System.Drawing.Size(1242, 748);
            this.Load += new System.EventHandler(this.ucCustomer_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerTbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCus_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCus_ID;
        private System.Windows.Forms.Label label4;
    }
}
