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
    public partial class FrmBarangAdd : DevExpress.XtraEditors.XtraForm
    {
        public string kd_barang { get; set; }

        public void init()
        {
            if (this.Text.ToLower().Contains("tambah"))
            {
                var txt = new TextEdit[] { txt_nama};
                foreach (TextEdit t in txt)
                {
                    t.EditValue = "";
                }

                txt_harga.EditValue = 0;
                txt_stok.EditValue = 0;
                cbo_satuan.SelectedIndex = 0;
                cbo_jenis.SelectedIndex = 0;
                txt_kd_barang.EditValue = Controllers.CBarang.get_kode();
            }
            else
            {
                var data = Controllers.CBarang.get_detail(this.kd_barang);
                txt_kd_barang.EditValue = kd_barang;
                txt_nama.EditValue = data.nama;
                cbo_satuan.SelectedItem = data.satuan;
                txt_harga.EditValue = data.harga;
                txt_stok.EditValue = data.stok;
                cbo_jenis.EditValue = data.jenis;
            }
        }

        public FrmBarangAdd()
        {
            InitializeComponent();
        }

        private void FrmBarangAdd_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void btn_simpan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var txt = new TextEdit[] { txt_nama};
            foreach (var t in txt)
            {
                if (t.EditValue.ToString() == "")
                {
                    Helpers.Generic.MsgError(t.Tag.ToString() + " tidak boleh kosong");
                    t.Focus();
                    return;
                }
            }

            var data = new Models.barang()
            {
                kd_barang = txt_kd_barang.EditValue.ToString(),
                nama = txt_nama.EditValue.ToString(),
                jenis = cbo_jenis.EditValue.ToString(),
                harga = Convert.ToInt32(txt_harga.EditValue),
                stok = Convert.ToInt32(txt_stok.EditValue),
                satuan = cbo_satuan.EditValue.ToString()
            };

            if (this.Text.ToLower().Contains("tambah"))
            {
                Controllers.CBarang.insert(data);
            }
            else
            {
                Controllers.CBarang.update(data);
            }

            var frm = (FrmBarang)this.Owner;
            frm.init();
            this.Close();
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