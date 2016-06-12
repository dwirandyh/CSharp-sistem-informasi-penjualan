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
    public partial class FrmRptKonsumenPeriode : DevExpress.XtraEditors.XtraForm
    {
        public FrmRptKonsumenPeriode()
        {
            InitializeComponent();
        }

        private void FrmRptKonsumenPeriode_Load(object sender, EventArgs e)
        {
            dtp_tgl1.EditValue = DateTime.Now;
            dtp_tgl2.EditValue = DateTime.Now;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reportViewer1.DataSource = Controllers.CPenjualan.get_report(Convert.ToDateTime(dtp_tgl1.EditValue), Convert.ToDateTime(dtp_tgl2.EditValue));
            reportViewer1.ReportName = "RptKonsumenPeriode";
            reportViewer1.GenerateReport();
            reportViewer1.Report.Parameters["periode"].Value = string.Format("{0:dd/MM/yyyy} s/d {1:dd/MM/yyyy}", Convert.ToDateTime(dtp_tgl1.EditValue), Convert.ToDateTime(dtp_tgl2.EditValue));
            reportViewer1.ShowReport();
        }

    }
}