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
    public partial class FrmRptBarang2 : DevExpress.XtraEditors.XtraForm
    {
        public string Label { get; set; }
        public List<Controllers.satuanbarang> DataSatuan{ get; set; }
        public List<Controllers.jenisbarang> DataJenis { get; set; }

        public FrmRptBarang2()
        {
            InitializeComponent();
        }

        private void FrmRptBarangSatuan_Load(object sender, EventArgs e)
        {
            if (Label.Contains("Satuan"))
            {
                this.Text = "Laporan Barang Per Satuan";
                repositoryItemCheckedComboBoxEdit1.DataSource = this.DataSatuan;
                repositoryItemCheckedComboBoxEdit1.ValueMember = "satuan";
                repositoryItemCheckedComboBoxEdit1.DisplayMember = "satuan";
            }
            else
            {
                this.Text = "Laporan Barang Per Jenis";
                repositoryItemCheckedComboBoxEdit1.DataSource = this.DataJenis;
                repositoryItemCheckedComboBoxEdit1.ValueMember = "jenis";
                repositoryItemCheckedComboBoxEdit1.DisplayMember = "jenis";
            }
            lbl_filter.Caption = this.Label;
        }

        private void btn_tampil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Label.Contains("Satuan"))
            {
                reportViewer1.DataSource = Controllers.CBarang.get_report_per_satuan(cbo_filter.EditValue.ToString());
                reportViewer1.ReportName = "RptBarangSatuan";
            }
            else
            {
                reportViewer1.DataSource = Controllers.CBarang.get_report_per_jenis(cbo_filter.EditValue.ToString());
                reportViewer1.ReportName = "RptBarangJenis";
            }
            reportViewer1.GenerateReport();
            reportViewer1.ShowReport();
        }
    }
}