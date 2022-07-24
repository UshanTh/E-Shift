namespace E_Shift.Admin_Dashboard
{
    partial class frmcustomer_Info
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomer_Info));
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_ShiftDataSet = new E_Shift.E_ShiftDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eShiftDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new E_Shift.E_ShiftDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new E_Shift.E_ShiftDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ShiftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShiftDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.e_ShiftDataSet;
            // 
            // e_ShiftDataSet
            // 
            this.e_ShiftDataSet.DataSetName = "E_ShiftDataSet";
            this.e_ShiftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.customerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "E_Shift.Admin_Dashboard.customer_Details.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1135, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // eShiftDataSetBindingSource
            // 
            this.eShiftDataSetBindingSource.DataSource = this.e_ShiftDataSet;
            this.eShiftDataSetBindingSource.Position = 0;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = E_Shift.E_ShiftDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmcustomer_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 594);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcustomer_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.frmcustomer_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ShiftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShiftDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource eShiftDataSetBindingSource;
        private E_ShiftDataSet e_ShiftDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private E_ShiftDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private E_ShiftDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}