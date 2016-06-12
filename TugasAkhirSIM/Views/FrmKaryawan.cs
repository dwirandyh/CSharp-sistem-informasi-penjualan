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
    public partial class FrmKaryawan : DevExpress.XtraEditors.XtraForm
    {
        public void init()
        {
            gridControl1.DataSource = Controllers.CKaryawan.get_data();
            cbo_cari.SelectedIndex = 0;
            txt_cari.EditValue = "";
        }

        public FrmKaryawan()
        {
            InitializeComponent();
        }


        private void FrmKaryawan_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void txt_cari_EditValueChanged(object sender, EventArgs e)
        {
             gridControl1.DataSource = Controllers.CKaryawan.search(cbo_cari.EditValue.ToString(), txt_cari.EditValue.ToString());
        }

        private void btn_tambah_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmKaryawanAdd()
            {
                Text = "Tambah Data Karyawan"
            };
            Helpers.Generic.ShowAdd(this, frm);
        }

        private void btn_perbaiki_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var index = gridView1.GetSelectedRows();
            var frm = new FrmKaryawanAdd()
            {
                Text = "Perbaiki Data Karyawan",
                kd_karyawan = gridView1.GetRowCellValue(index[0], "kd_karyawan").ToString()
            };
            Helpers.Generic.ShowAdd(this, frm);
        }

        private void btn_hapus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var index = gridView1.GetSelectedRows();
            if (index.Count() > 0)
            {
                if (Helpers.Generic.MsgQuestion("Hapus data yang dipilih?") == DialogResult.Yes)
                {
                    var data = new Models.karyawan()
                    {
                        kd_karyawan = gridView1.GetRowCellValue(index[0], "kd_karyawan").ToString()
                    };
                    Controllers.CKaryawan.delete(data);
                }
            }
            this.init();
        }

        private void btn_tutup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}