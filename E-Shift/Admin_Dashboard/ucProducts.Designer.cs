namespace E_Shift.Admin_Dashboard
{
    partial class ucProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProduct_type = new System.Windows.Forms.ComboBox();
            this.dgvProduct_tbl = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct_tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 2);
            this.panel1.TabIndex = 82;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnAdd.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnAdd.Location = new System.Drawing.Point(50, 656);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 63);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtDesc.Location = new System.Drawing.Point(50, 573);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(417, 59);
            this.txtDesc.TabIndex = 3;
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtProName.Location = new System.Drawing.Point(50, 380);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(417, 31);
            this.txtProName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 24);
            this.label8.TabIndex = 79;
            this.label8.Text = "Description (optional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "Product Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 33);
            this.label1.TabIndex = 65;
            this.label1.Text = "Product Information";
            // 
            // cmbProduct_type
            // 
            this.cmbProduct_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct_type.Font = new System.Drawing.Font("Helvetica", 12F);
            this.cmbProduct_type.FormattingEnabled = true;
            this.cmbProduct_type.Items.AddRange(new object[] {
            "Furniture",
            "Appliances",
            "Electronic Equipment",
            "Storage and Organizational Items"});
            this.cmbProduct_type.Location = new System.Drawing.Point(50, 464);
            this.cmbProduct_type.Name = "cmbProduct_type";
            this.cmbProduct_type.Size = new System.Drawing.Size(417, 32);
            this.cmbProduct_type.TabIndex = 2;
            // 
            // dgvProduct_tbl
            // 
            this.dgvProduct_tbl.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProduct_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct_tbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct_tbl.Location = new System.Drawing.Point(535, 262);
            this.dgvProduct_tbl.Name = "dgvProduct_tbl";
            this.dgvProduct_tbl.RowTemplate.Height = 24;
            this.dgvProduct_tbl.Size = new System.Drawing.Size(619, 370);
            this.dgvProduct_tbl.TabIndex = 84;
            this.dgvProduct_tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_tbl_CellClick);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtID.Location = new System.Drawing.Point(782, 204);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 31);
            this.txtID.TabIndex = 85;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtCustomerId.Location = new System.Drawing.Point(50, 205);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(417, 31);
            this.txtCustomerId.TabIndex = 0;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            this.txtCustomerId.Leave += new System.EventHandler(this.txtCustomerId_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 88;
            this.label5.Text = "Customer Id";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnSave.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnSave.Location = new System.Drawing.Point(282, 656);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 63);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomername
            // 
            this.txtCustomername.Font = new System.Drawing.Font("Helvetica", 12F);
            this.txtCustomername.Location = new System.Drawing.Point(50, 292);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.ReadOnly = true;
            this.txtCustomername.Size = new System.Drawing.Size(417, 31);
            this.txtCustomername.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 91;
            this.label6.Text = "Customer Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnSearch.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnSearch.Location = new System.Drawing.Point(1003, 194);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 45);
            this.btnSearch.TabIndex = 92;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnDelete.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnDelete.Location = new System.Drawing.Point(978, 656);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 63);
            this.btnDelete.TabIndex = 93;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 94;
            this.label7.Text = "Search By";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.Font = new System.Drawing.Font("Helvetica", 12F);
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Customer Id",
            "Product Id"});
            this.cmbSearchBy.Location = new System.Drawing.Point(535, 203);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(213, 32);
            this.cmbSearchBy.TabIndex = 95;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnClear.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnClear.Location = new System.Drawing.Point(746, 656);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 63);
            this.btnClear.TabIndex = 96;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(159)))));
            this.btnAssign.Font = new System.Drawing.Font("Helvetica", 13.8F);
            this.btnAssign.Location = new System.Drawing.Point(514, 656);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(175, 63);
            this.btnAssign.TabIndex = 97;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustomername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvProduct_tbl);
            this.Controls.Add(this.cmbProduct_type);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(1242, 748);
            this.Load += new System.EventHandler(this.ucProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct_tbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProduct_type;
        private System.Windows.Forms.DataGridView dgvProduct_tbl;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAssign;
    }
}
