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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private void init()
        {
            txt_username.EditValue = "";
            txt_password.EditValue = "";
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void btn_batal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_login_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_username.EditValue.ToString() == "" && txt_password.EditValue == "")
            {
                Helpers.Generic.MsgEx("Username & password tidak boleh kosong");
            }
            else if (txt_username.EditValue.ToString() == "")
            {
                Helpers.Generic.MsgEx("Username tidak boleh kosong");
            }
            else if (txt_password.EditValue.ToString() == "")
            {
                Helpers.Generic.MsgEx("Password tidak boleh kosong");
            }
            else
            {
                var data = Controllers.CKaryawan.check_login(txt_username.EditValue.ToString());
                if (data == null)
                {
                    Helpers.Generic.MsgEx("Username anda salah");
                }
                else if (data.username == txt_username.EditValue.ToString() && data.password == txt_password.EditValue.ToString())  
                {
                    var frm = (MainMenu)this.Owner;
                    frm.kd_karyawan = data.kd_karyawan;
                    frm.nama = data.nama;
                    frm.hak_akses = data.hak_akses;
                    frm.set_rule();
                    this.Close();
                }
                else
                {
                    Helpers.Generic.MsgEx("Password anda salah");
                }
            }
        }
    }
}