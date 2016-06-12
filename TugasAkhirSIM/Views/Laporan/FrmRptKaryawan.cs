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
    public partial class FrmRptKaryawan : DevExpress.XtraEditors.XtraForm
    {
        public FrmRptKaryawan()
        {
            InitializeComponent();
        }

        private void btn_tampilkan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reportViewer1.DataSource = Controllers.CKaryawan.get_report(cbo_filter.EditValue.ToString(), txt_filter.EditValue.ToString());
            reportViewer1.ReportName = "RptKaryawan";
            reportViewer1.GenerateReport();
            reportViewer1.ShowReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmRptKaryawan_Load(object sender, EventArgs e)
        {
            cbo_filter.EditValue = "Kode Karyawan";
            txt_filter.EditValue = "";
        }
    }
}