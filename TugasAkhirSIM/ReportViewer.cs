using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TugasAkhirSIM
{
    public partial class ReportViewer : UserControl
    {
        public string ReportName { get; set; }
        public DataSet1 DataSource { get; set; }
        public XtraReport Report { get; set; }

        public void ShowReport()
        {
            this.Report.CreateDocument();
            documentViewer1.DocumentSource = this.Report;
        }

        public void GenerateReport()
        {
            this.Report = XtraReport.FromFile(Application.StartupPath + "/Laporan/" + this.ReportName + ".repx", true);
            this.Report.DataSource = this.DataSource;
            this.Report.DataMember = Report.DataMember;
            
        }

        public ReportViewer()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
