using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TugasAkhirSIM.Views.Laporan
{
    public partial class FrmCetak : DevExpress.XtraEditors.XtraForm
    {
        public string no_faktur { get; set; }

        public FrmCetak()
        {
            InitializeComponent();
        }

        private void FrmCetak_Load(object sender, EventArgs e)
        {
            reportViewer1.DataSource = Controllers.CPembayaran.get_faktur(this.no_faktur);
            reportViewer1.ReportName = "FakturPenjualan";
            reportViewer1.GenerateReport();
            reportViewer1.ShowReport();
        }
    }
}