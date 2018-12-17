namespace Catch_A_Fire.Forms
{
    partial class ReportView
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
            this.rptPrint = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Paymount_Select_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Paymount_Select_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptPrint
            // 
            this.rptPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ds";
            reportDataSource1.Value = this.Paymount_Select_ResultBindingSource;
            this.rptPrint.LocalReport.DataSources.Add(reportDataSource1);
            this.rptPrint.LocalReport.ReportEmbeddedResource = "Catch_A_Fire.Forms.rprtMoyOt4et.rdlc";
            this.rptPrint.Location = new System.Drawing.Point(0, 0);
            this.rptPrint.Name = "rptPrint";
            this.rptPrint.Size = new System.Drawing.Size(619, 384);
            this.rptPrint.TabIndex = 0;
            // 
            // Paymount_Select_ResultBindingSource
            // 
            this.Paymount_Select_ResultBindingSource.DataSource = typeof(Catch_A_Fire.Paymount_Select_Result);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 384);
            this.Controls.Add(this.rptPrint);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.Load += new System.EventHandler(this.ReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Paymount_Select_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPrint;
        private System.Windows.Forms.BindingSource Paymount_Select_ResultBindingSource;
    }
}