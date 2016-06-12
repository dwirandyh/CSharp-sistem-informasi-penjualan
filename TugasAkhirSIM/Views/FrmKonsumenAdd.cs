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
    public partial class FrmKonsumenAdd : DevExpress.XtraEditors.XtraForm
    {
        public string kd_konsumen { get; set; }

        public void init()
        {
            if (this.Text.ToLower().Contains("tambah"))
            {
                var txt = new TextEdit[] { txt_nama, txt_alamat, txt_email, txt_no_telepon };
                foreach (TextEdit t in txt)
                {
                    t.EditValue = "";
                }

                txt_kd_konsumen.EditValue = Controllers.CKonsumen.get_kode();
            }
            else
            {
                var data = Controllers.CKonsumen.get_detail(this.kd_konsumen);
                txt_kd_konsumen.EditValue = kd_konsumen;
                txt_nama.EditValue = data.nama;
                txt_alamat.EditValue = data.alamat;
                txt_email.EditValue = data.email;
                txt_no_telepon.EditValue = data.no_telepon;
            }
        }

        public FrmKonsumenAdd()
        {
            InitializeComponent();
        }

        private void FrmKonsumenAdd_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void btn_simpan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var txt = new TextEdit[] { txt_nama, txt_alamat, txt_email, txt_no_telepon};
            foreach (var t in txt)
            {
                if (t.EditValue.ToString() == "")
                {
                    Helpers.Generic.MsgError(t.Tag.ToString() + " tidak boleh kosong");
                    t.Focus();
                    return;
                }
            }
            var data = new Models.konsumen()
            {
                kd_konsumen = txt_kd_konsumen.EditValue.ToString(),
                nama = txt_nama.EditValue.ToString(),
                alamat = txt_alamat.EditValue.ToString(),
                email = txt_email.EditValue.ToString(),
                no_telepon = txt_no_telepon.EditValue.ToString()
            };

            if (this.Text.ToLower().Contains("tambah"))
            {
                Controllers.CKonsumen.insert(data);
            }
            else
            {
                Controllers.CKonsumen.update(data);
            }

            var frm = (FrmKonsumen)this.Owner;
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