using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace TugasAkhirSIM.Views
{
    public partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string kd_karyawan { 
            get
            {
                return lbl_kd_karyawan.Caption;
            }
            set
            {
                lbl_kd_karyawan.Caption = value;
            }
        }

        public string nama {
            get
            {
                return lbl_nama.Caption;
            }
            set
            {
                lbl_nama.Caption = value;
            }
        }

        public string hak_akses
        {
            get
            {
                return lbl_hak_akses.Caption;
            }
            set
            {
                lbl_hak_akses.Caption = value;
            }
        }

        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void init()
        {
            this.kd_karyawan = "";
            this.nama = "";
            this.hak_akses = "";
            page_laporan.Visible = false;
            page_master.Visible = true;
            page_transaksi.Visible = false;
            group_master.Visible = false;
            group_barang.Visible = false;
            btn_login2.Visibility = BarItemVisibility.Always;
            btn_logout2.Visibility = BarItemVisibility.Never;
            tabbedView1.Controller.CloseAll();
        }

        public void set_rule()
        {
            page_master.Visible = true;
            page_transaksi.Visible = true;
            group_master.Visible = true;
            group_barang.Visible = true;
            btn_login2.Visibility = BarItemVisibility.Never;
            btn_logout2.Visibility = BarItemVisibility.Always;
            var frm = new FrmDashboard();
            Helpers.Generic.ShowChild(this, frm);

            if (hak_akses == "Karyawan")
            {
                page_laporan.Visible = false;
                group_barang.Visible = false;
                btn_karyawan.Visibility = BarItemVisibility.Never;
                btn_konsumen.Visibility = BarItemVisibility.Always;
                btn_barang.Visibility = BarItemVisibility.Never;
                btn_pembayaran.Visibility = BarItemVisibility.Never;
                btn_penjualan.Visibility = BarItemVisibility.Always;
            }
            else
            {
                page_laporan.Visible = true;
                group_barang.Visible = true;
                btn_karyawan.Visibility = BarItemVisibility.Always;
                btn_konsumen.Visibility = BarItemVisibility.Never;
                btn_barang.Visibility = BarItemVisibility.Always;
                btn_pembayaran.Visibility = BarItemVisibility.Always;
                btn_penjualan.Visibility = BarItemVisibility.Never;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.init();
        }


        private void btn_karyawan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmKaryawan();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void btn_barang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmBarang();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmKonsumen();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void btn_penjualan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmPenjualan();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void btn_pembayaran_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmPembayaran();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void btn_rpt_konsumen_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Laporan.FrmRptKonsumen();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void btn_konsumen_periode_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Laporan.FrmRptKonsumenPeriode();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void btn_rpt_karyawan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Laporan.FrmRptKaryawan();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void btn_rpt_barang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Laporan.FrmRptBarang();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_rpt_barang_satuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Laporan.FrmRptBarang2();
            frm.Label = "Pilih Satuan Barang : ";
            frm.DataSatuan = Controllers.CBarang.get_satuan();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void btn_rpt_barang_jenis_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Laporan.FrmRptBarang2();
            frm.Label = "Pilih Jenis Barang : ";
            frm.DataJenis = Controllers.CBarang.get_jenis();
            Helpers.Generic.ShowChild(this, frm);
        }

        private void btn_logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_login_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btn_login2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmLogin();
            Helpers.Generic.ShowAdd(this, frm);

        }
    }
}