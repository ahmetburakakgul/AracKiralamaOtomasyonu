namespace Rent_A_Car
{
    partial class aracraporlama
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
            this.ARACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentACarDataSet = new Rent_A_Car.RentACarDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ARACTableAdapter = new Rent_A_Car.RentACarDataSetTableAdapters.ARACTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ARACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ARACBindingSource
            // 
            this.ARACBindingSource.DataMember = "ARAC";
            this.ARACBindingSource.DataSource = this.RentACarDataSet;
            // 
            // RentACarDataSet
            // 
            this.RentACarDataSet.DataSetName = "RentACarDataSet";
            this.RentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ARACBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rent_A_Car.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(986, 646);
            this.reportViewer1.TabIndex = 0;
            // 
            // ARACTableAdapter
            // 
            this.ARACTableAdapter.ClearBeforeFill = true;
            // 
            // aracraporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 646);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "aracraporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aracraporlama";
            this.Load += new System.EventHandler(this.aracraporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ARACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentACarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ARACBindingSource;
        private RentACarDataSet RentACarDataSet;
        private RentACarDataSetTableAdapters.ARACTableAdapter ARACTableAdapter;
    }
}