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
    public partial class FrmKaryawanAdd : DevExpress.XtraEditors.XtraForm
    {
        public string kd_karyawan { get; set; }

        public void init()
        {
            if (this.Text.ToLower().Contains("tambah"))
            {
                var txt = new TextEdit[] { txt_nama, txt_alamat, txt_email, txt_username, txt_password, txt_no_telepon };
                foreach (TextEdit t in txt)
                {
                    t.EditValue = "";
                }

                cbo_hak_akses.SelectedIndex = 0;
                txt_kd_karyawan.EditValue = Controllers.CKaryawan.get_kode();
            }
            else
            {
                var data = Controllers.CKaryawan.get_detail(this.kd_karyawan);
                txt_kd_karyawan.EditValue = kd_karyawan;
                txt_nama.EditValue = data.nama;
                txt_alamat.EditValue = data.alamat;
                txt_email.EditValue = data.email;
                txt_username.EditValue = data.username;
                txt_password.EditValue = data.password;
                txt_no_telepon.EditValue = data.no_telepon;
                cbo_hak_akses.SelectedItem = data.hak_akses;
            }
        }

        public FrmKaryawanAdd()
        {
            InitializeComponent();
        }

        private void FrmKaryawanAdd_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void btn_simpan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var txt = new TextEdit[] { txt_nama, txt_alamat, txt_email, txt_username, txt_password, txt_no_telepon };
            foreach (var t in txt)
            {
                if (t.EditValue.ToString() == "" || t.EditValue == null)
                {
                    Helpers.Generic.MsgError(t.Tag.ToString() + " tidak boleh kosong");
                    t.Focus();
                    return;
                }
            }
            var data = new Models.karyawan()
            {
                kd_karyawan = txt_kd_karyawan.EditValue.ToString(),
                nama = txt_nama.EditValue.ToString(),
                alamat = txt_alamat.EditValue.ToString(),
                email = txt_email.EditValue.ToString(),
                username = txt_username.EditValue.ToString(),
                password = txt_password.EditValue.ToString(),
                no_telepon = txt_no_telepon.EditValue.ToString(),
                hak_akses = cbo_hak_akses.EditValue.ToString()
            };

            if (this.Text.ToLower().Contains("tambah"))
            {
                Controllers.CKaryawan.insert(data);
            }
            else
            {
                Controllers.CKaryawan.update(data);
            }

            var frm = (FrmKaryawan)this.Owner;
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