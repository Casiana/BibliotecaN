namespace BibliotecaN
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Biblioteca2DataSet2 = new BibliotecaN.Biblioteca2DataSet2();
            this.raport_view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raport_view1TableAdapter = new BibliotecaN.Biblioteca2DataSet2TableAdapters.raport_view1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Biblioteca2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raport_view1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LendsBindingSource
            // 
            this.LendsBindingSource.DataMember = "Lends";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.raport_view1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BibliotecaN.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(733, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // Biblioteca2DataSet2
            // 
            this.Biblioteca2DataSet2.DataSetName = "Biblioteca2DataSet2";
            this.Biblioteca2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raport_view1BindingSource
            // 
            this.raport_view1BindingSource.DataMember = "raport_view1";
            this.raport_view1BindingSource.DataSource = this.Biblioteca2DataSet2;
            // 
            // raport_view1TableAdapter
            // 
            this.raport_view1TableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 432);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Biblioteca2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raport_view1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.BindingSource LendsBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource raport_view1BindingSource;
        private Biblioteca2DataSet2 Biblioteca2DataSet2;
        private Biblioteca2DataSet2TableAdapters.raport_view1TableAdapter raport_view1TableAdapter;
    }
}