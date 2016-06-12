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
    public partial class FrmRptBarang : DevExpress.XtraEditors.XtraForm
    {
        public FrmRptBarang()
        {
            InitializeComponent();
        }

        private void FrmRptBarang_Load(object sender, EventArgs e)
        {
            cbo_filter.EditValue = "Kode Barang";
            txt_filter.EditValue = "";
        }

        private void btn_tampilkan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reportViewer1.DataSource = Controllers.CBarang.get_report(cbo_filter.EditValue.ToString(), txt_filter.EditValue.ToString());
            reportViewer1.ReportName = "RptBarang";
            reportViewer1.GenerateReport();
            reportViewer1.ShowReport();
        }
    }
}