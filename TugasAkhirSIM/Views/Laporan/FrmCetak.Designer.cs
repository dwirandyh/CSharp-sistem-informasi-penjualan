namespace TugasAkhirSIM.Views.Laporan
{
    partial class FrmCetak
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
            this.reportViewer1 = new TugasAkhirSIM.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DataSource = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Report = null;
            this.reportViewer1.ReportName = null;
            this.reportViewer1.Size = new System.Drawing.Size(870, 427);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmCetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 427);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmCetak";
            this.Text = "Cetak";
            this.Load += new System.EventHandler(this.FrmCetak_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ReportViewer reportViewer1;
    }
}