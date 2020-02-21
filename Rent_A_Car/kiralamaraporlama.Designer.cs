namespace Rent_A_Car
{
    partial class kiralamaraporlama
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
            this.RentACarDataSet = new Rent_A_Car.RentACarDataSet();
            this.ARAC_KIRALAMABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARAC_KIRALAMATableAdapter = new Rent_A_Car.RentACarDataSetTableAdapters.ARAC_KIRALAMATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAC_KIRALAMABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ARAC_KIRALAMABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rent_A_Car.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1226, 515);
            this.reportViewer1.TabIndex = 0;
            // 
            // RentACarDataSet
            // 
            this.RentACarDataSet.DataSetName = "RentACarDataSet";
            this.RentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ARAC_KIRALAMABindingSource
            // 
            this.ARAC_KIRALAMABindingSource.DataMember = "ARAC_KIRALAMA";
            this.ARAC_KIRALAMABindingSource.DataSource = this.RentACarDataSet;
            // 
            // ARAC_KIRALAMATableAdapter
            // 
            this.ARAC_KIRALAMATableAdapter.ClearBeforeFill = true;
            // 
            // kiralamaraporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 515);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "kiralamaraporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kiralamaraporlama";
            this.Load += new System.EventHandler(this.kiralamaraporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAC_KIRALAMABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ARAC_KIRALAMABindingSource;
        private RentACarDataSet RentACarDataSet;
        private RentACarDataSetTableAdapters.ARAC_KIRALAMATableAdapter ARAC_KIRALAMATableAdapter;
    }
}