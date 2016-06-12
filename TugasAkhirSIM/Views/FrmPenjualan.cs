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
    public partial class FrmPenjualan : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtdetail;

        private void HitungTotal()
        {
            int total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                total += Convert.ToInt32(gridView1.GetRowCellValue(i, "total"));
                
            }
            txt_total_bayar.EditValue = total;
        }

        private void init()
        {
            dtp_tgl.EditValue = DateTime.Now;
            var main = (MainMenu)this.MdiParent;
            txt_kd_karyawan.EditValue = main.kd_karyawan;
            txt_nm_karyawan.EditValue = main.nama;
            txt_total_bayar.EditValue = 0;

            txt_no_faktur.EditValue = Controllers.CPenjualan.get_faktur();

            dtdetail = new DataTable();
            dtdetail.Columns.Add("kd_barang", typeof(string));
            dtdetail.Columns.Add("nama", typeof(string));
            dtdetail.Columns.Add("harga", typeof(string));
            dtdetail.Columns.Add("jumlah_beli", typeof(string));
            dtdetail.Columns.Add("total", typeof(string));
            dtdetail.Rows.Add(null, null, 0, 0, 0);
            gridControl1.DataSource = dtdetail;

            txt_no_faktur.Enabled = false;
        }

        public FrmPenjualan()
        {
            InitializeComponent();
        }

        private void FrmPenjualan_Load(object sender, EventArgs e)
        {
            var konsumen = Controllers.CKonsumen.get_data();
            cbo_kd_konsumen.Properties.DataSource = konsumen;
            if (konsumen.Count > 0)
            {
                cbo_kd_konsumen.EditValue = konsumen[0].kd_konsumen;
                txt_nama.EditValue = konsumen[0].nama;
                txt_alamat.EditValue = konsumen[0].alamat;
            }
            cbo_kd_barang.DataSource = Controllers.CBarang.get_data();

            this.init();
        }

        private void cbo_kd_konsumen_EditValueChanged(object sender, EventArgs e)
        {
            var view = cbo_kd_konsumen.Properties.View;
            var index = view.FocusedRowHandle;
            object row = view.GetRowCellValue(index, "kd_konsumen");
            if (row != null)
            {
                txt_nama.EditValue = view.GetRowCellValue(index, "nama");
                txt_alamat.EditValue = view.GetRowCellValue(index, "alamat");
            }
        }

        private void cbo_kd_barang_EditValueChanged(object sender, EventArgs e)
        {
            var cbo = (SearchLookUpEdit)sender;
            var view = cbo.Properties.View;
            var index = view.FocusedRowHandle;
            object row = view.GetRowCellValue(index, "kd_barang");
            if (row != null)
            {
                int[] idxgrid = gridView1.GetSelectedRows();
                gridView1.SetRowCellValue(idxgrid[0], "nama", view.GetRowCellValue(index, "nama"));
                gridView1.SetRowCellValue(idxgrid[0], "harga", view.GetRowCellValue(index, "harga"));
                gridView1.SetRowCellValue(idxgrid[0], "jumlah_beli", 0);
                gridView1.SetRowCellValue(idxgrid[0], "total", 0);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dtdetail.Rows.Add(null, null, 0, 0, 0);
                this.HitungTotal();
            }
            else if (e.KeyData == Keys.Delete)
            {
                gridView1.DeleteSelectedRows();
                this.HitungTotal();
            }
        }

        private void spin_jumlah_ValueChanged(object sender, EventArgs e)
        {
            int[] indexgrid = gridView1.GetSelectedRows();
            var barang = gridView1.GetRowCellValue(indexgrid[0], "nama");
            if (barang != DBNull.Value)
            {
                SpinEdit spin = (SpinEdit)sender;
                int qty = Convert.ToInt32(spin.EditValue);
                int harga = Convert.ToInt32(gridView1.GetRowCellValue(indexgrid[0], "harga"));
                gridView1.SetRowCellValue(indexgrid[0], "total", (qty * harga));

                this.HitungTotal();
            }
        }

        private void btn_simpan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                Helpers.Generic.MsgEx("Detail barang tidak boleh kosong");
                return;
            }

            var penjualan = new Models.penjualan()
            {
                no_faktur = txt_no_faktur.EditValue.ToString(),
                kd_konsumen = cbo_kd_konsumen.EditValue.ToString(),
                kd_karyawan = txt_kd_karyawan.EditValue.ToString(),
                tgl = Convert.ToDateTime(dtp_tgl.EditValue),
                total = Convert.ToInt32(txt_total_bayar.EditValue),
                status = 0
            };

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var no_faktur = gridView1.GetRowCellValue(i, "nama").ToString();
                if (no_faktur != "")
                {
                    var detail = new Models.detail_penjualan()
                    {
                        no_faktur = txt_no_faktur.EditValue.ToString(),
                        kd_barang = gridView1.GetRowCellValue(i, "kd_barang").ToString(),
                        harga = Convert.ToInt32(gridView1.GetRowCellValue(i, "harga")),
                        jumlah = Convert.ToInt32(gridView1.GetRowCellValue(i, "jumlah_beli")),
                        total = Convert.ToInt32(gridView1.GetRowCellValue(i, "total"))
                    };
                    penjualan.detail_penjualans.Add(detail);
                }
            }

            Controllers.CPenjualan.insert(penjualan);
            Helpers.Generic.MsgInfo("Data penjualan berhasil disimpan");
            this.init();
        }

        private void btn_batal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_tutup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}