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
    public partial class FrmRptKonsumen : DevExpress.XtraEditors.XtraForm
    {
        public FrmRptKonsumen()
        {
            InitializeComponent();
        }

        private void FrmRptKonsumen_Load(object sender, EventArgs e)
        {
            cbo_filter.EditValue = "Kode Konsumen";
            txt_filter.EditValue = "";
        }

        private void btn_tampil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reportViewer1.DataSource = Controllers.CKonsumen.get_report(cbo_filter.EditValue.ToString(), txt_filter.EditValue.ToString());
            reportViewer1.ReportName = "RptKonsumen";
            reportViewer1.GenerateReport();
            reportViewer1.ShowReport();
        }
    }
}