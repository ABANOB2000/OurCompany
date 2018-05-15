namespace OurCompany
{
    partial class report
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.company2DataSet = new OurCompany.company2DataSet();
            this.View_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_1TableAdapter = new OurCompany.company2DataSetTableAdapters.View_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.company2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OurCompany.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(749, 358);
            this.reportViewer1.TabIndex = 0;
            // 
            // company2DataSet
            // 
            this.company2DataSet.DataSetName = "company2DataSet";
            this.company2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_1BindingSource
            // 
            this.View_1BindingSource.DataMember = "View_1";
            this.View_1BindingSource.DataSource = this.company2DataSet;
            // 
            // View_1TableAdapter
            // 
            this.View_1TableAdapter.ClearBeforeFill = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 358);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.company2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource View_1BindingSource;
        private company2DataSetTableAdapters.View_1TableAdapter View_1TableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public company2DataSet company2DataSet;
    }
}