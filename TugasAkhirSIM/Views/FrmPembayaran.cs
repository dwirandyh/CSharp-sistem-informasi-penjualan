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
    public partial class FrmPembayaran : DevExpress.XtraEditors.XtraForm
    {
        private void init()
        {
            var data = Controllers.CPembayaran.get_penjualan();
            cbo_no_faktur.Properties.DataSource = data;
            cbo_no_faktur.EditValue = null;

            TextEdit[] txt = new TextEdit[] { txt_kd_karyawan, txt_nm_karyawan, txt_kd_konsumen, txt_nm_konsumen };
            foreach (var t in txt)
            {
                t.EditValue = "";
            }
            txt_total_bayar.EditValue = 0;
            txt_dibayar.EditValue = 0;
            txt_kembali.EditValue = 0;

            gridControl2.DataSource = null;
        }

        public FrmPembayaran()
        {
            InitializeComponent();
        }

        private void FrmPembayaran_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void cbo_no_faktur_EditValueChanged(object sender, EventArgs e)
        {
            var view = cbo_no_faktur.Properties.View;
            var index = view.FocusedRowHandle;
            object row = view.GetRowCellValue(index, "no_faktur");
            if (row != null)
            {
                var data = Controllers.CPembayaran.get_detail_penjualan(row.ToString());
                dtp_tgl.EditValue = data.tgl;
                txt_kd_karyawan.EditValue = data.kd_karyawan;
                txt_nm_karyawan.EditValue = data.karyawan.nama;
                txt_kd_konsumen.EditValue = data.kd_konsumen;
                txt_nm_konsumen.EditValue = data.konsumen.nama;
                txt_total_bayar.EditValue = data.total;
                txt_kembali.EditValue = (0 - data.total);
                txt_dibayar.EditValue = 0;

                var detail = Controllers.CPembayaran.get_detail_barang(data.no_faktur);
                gridControl2.DataSource = detail;
            }
        }

        private void btn_pembayaran_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbo_no_faktur.EditValue == null)
            {
                Helpers.Generic.MsgEx("Data Penjualan tidak boleh kosong");
                return;
            }
            if (Convert.ToInt32(txt_kembali.EditValue) < 0)
            {
                Helpers.Generic.MsgEx("Uang yang dibayarkan belum cukup");
                return;
            }
            var main = (MainMenu)this.MdiParent;
            var data = new Models.pembayaran()
            {
                no_faktur = cbo_no_faktur.EditValue.ToString(),
                tgl = Convert.ToDateTime(dtp_tgl.EditValue),
                kd_karyawan = main.kd_karyawan,
                total_bayar = Convert.ToInt32(txt_total_bayar.EditValue),
                dibayar = Convert.ToInt32(txt_dibayar.EditValue),
                kembali = Convert.ToInt32(txt_kembali.EditValue)
            };

            if (Controllers.CPembayaran.insert(data))
            {
                Helpers.Generic.MsgInfo("Data Pembayaran berhasil disimpan");
                var frm = new Laporan.FrmCetak() { no_faktur = cbo_no_faktur.EditValue.ToString() };
                Helpers.Generic.ShowAdd(this, frm);
                this.init();
            }
        }

        private void btn_batal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_tutup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txt_dibayar_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_total_bayar.EditValue) > 0)
            {
                var total_bayar = Convert.ToInt32(txt_total_bayar.EditValue);
                var kembali = Convert.ToInt32(txt_dibayar.EditValue) - total_bayar;
                txt_kembali.EditValue = kembali;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            var data = Controllers.CPembayaran.get_penjualan();
            cbo_no_faktur.Properties.DataSource = data;
            cbo_no_faktur.EditValue = null;
        }

        private void btn_cetak_faktur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmCetakFaktur();
            Helpers.Generic.ShowAdd(this, frm);
        }
    }
}