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

namespace TugasAkhirSIM.Views
{
    public partial class FrmCetakFaktur : DevExpress.XtraEditors.XtraForm
    {
        public FrmCetakFaktur()
        {
            InitializeComponent();
        }

        private void FrmCetakFaktur_Load(object sender, EventArgs e)
        {
            txt_cari.EditValue = "";
        }

        private void txt_cari_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = Controllers.CPembayaran.search(txt_cari.EditValue.ToString());
        }

        private void btn_cetak_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var index = gridView1.GetSelectedRows();
            var frm = new Laporan.FrmCetak() { no_faktur = gridView1.GetRowCellValue(index[0], "no_faktur").ToString() };
            Helpers.Generic.ShowAdd(this, frm);
        }
    }
}