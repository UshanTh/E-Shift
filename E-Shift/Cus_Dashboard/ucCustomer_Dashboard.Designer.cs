﻿namespace E_Shift.Cus_Dashboard
{
    partial class ucCustomer_Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbljobs_Count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblgoods_Count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbljobs_Count);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(248, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 115);
            this.panel1.TabIndex = 0;
            // 
            // lbljobs_Count
            // 
            this.lbljobs_Count.AutoSize = true;
            this.lbljobs_Count.Font = new System.Drawing.Font("Helvetica", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljobs_Count.ForeColor = System.Drawing.Color.Blue;
            this.lbljobs_Count.Location = new System.Drawing.Point(109, 68);
            this.lbljobs_Count.Name = "lbljobs_Count";
            this.lbljobs_Count.Size = new System.Drawing.Size(38, 28);
            this.lbljobs_Count.TabIndex = 1;
            this.lbljobs_Count.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Jobs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblgoods_Count);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(661, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 115);
            this.panel2.TabIndex = 0;
            // 
            // lblgoods_Count
            // 
            this.lblgoods_Count.AutoSize = true;
            this.lblgoods_Count.Font = new System.Drawing.Font("Helvetica", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgoods_Count.ForeColor = System.Drawing.Color.Blue;
            this.lblgoods_Count.Location = new System.Drawing.Point(109, 68);
            this.lblgoods_Count.Name = "lblgoods_Count";
            this.lblgoods_Count.Size = new System.Drawing.Size(38, 28);
            this.lblgoods_Count.TabIndex = 1;
            this.lblgoods_Count.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "My Goods";
            // 
            // ucCustomer_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucCustomer_Dashboard";
            this.Size = new System.Drawing.Size(1242, 748);
            this.Load += new System.EventHandler(this.ucCustomer_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbljobs_Count;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblgoods_Count;
        private System.Windows.Forms.Label label4;
    }
}
