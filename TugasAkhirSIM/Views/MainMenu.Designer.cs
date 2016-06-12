namespace TugasAkhirSIM.Views
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btn_login = new DevExpress.XtraBars.BarButtonItem();
            this.btn_logout = new DevExpress.XtraBars.BarButtonItem();
            this.btn_karyawan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_konsumen = new DevExpress.XtraBars.BarButtonItem();
            this.btn_barang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_penjualan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_pembayaran = new DevExpress.XtraBars.BarButtonItem();
            this.btn_rpt_barang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_rpt_konsumen = new DevExpress.XtraBars.BarButtonItem();
            this.btn_rpt_barang_satuan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_rpt_barang_jenis = new DevExpress.XtraBars.BarButtonItem();
            this.btn_rpt_karyawan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_konsumen_periode = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lbl_kd_karyawan = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.lbl_nama = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            this.lbl_hak_akses = new DevExpress.XtraBars.BarStaticItem();
            this.btn_login2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_logout2 = new DevExpress.XtraBars.BarButtonItem();
            this.page_master = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.group_master = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.group_barang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_transaksi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_laporan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_karyawan,
            this.btn_konsumen,
            this.btn_barang,
            this.btn_penjualan,
            this.btn_pembayaran,
            this.btn_rpt_barang,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btn_rpt_konsumen,
            this.btn_rpt_barang_satuan,
            this.btn_rpt_barang_jenis,
            this.btn_rpt_karyawan,
            this.btn_konsumen_periode,
            this.btn_login,
            this.btn_logout,
            this.barStaticItem1,
            this.lbl_kd_karyawan,
            this.barStaticItem3,
            this.lbl_nama,
            this.barStaticItem5,
            this.lbl_hak_akses,
            this.btn_login2,
            this.btn_logout2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.page_master,
            this.page_transaksi,
            this.page_laporan});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(941, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.btn_login);
            this.applicationMenu1.ItemLinks.Add(this.btn_logout);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // btn_login
            // 
            this.btn_login.Caption = "Login";
            this.btn_login.Id = 15;
            this.btn_login.Name = "btn_login";
            this.btn_login.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_login_ItemClick);
            // 
            // btn_logout
            // 
            this.btn_logout.Caption = "Logout";
            this.btn_logout.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_logout.Glyph")));
            this.btn_logout.Id = 18;
            this.btn_logout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_logout.LargeGlyph")));
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_logout_ItemClick);
            // 
            // btn_karyawan
            // 
            this.btn_karyawan.Caption = "Karyawan";
            this.btn_karyawan.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_karyawan.Glyph")));
            this.btn_karyawan.Id = 1;
            this.btn_karyawan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_karyawan.LargeGlyph")));
            this.btn_karyawan.Name = "btn_karyawan";
            this.btn_karyawan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_karyawan_ItemClick);
            // 
            // btn_konsumen
            // 
            this.btn_konsumen.Caption = "Konsumen";
            this.btn_konsumen.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_konsumen.Glyph")));
            this.btn_konsumen.Id = 2;
            this.btn_konsumen.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_konsumen.LargeGlyph")));
            this.btn_konsumen.Name = "btn_konsumen";
            this.btn_konsumen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btn_barang
            // 
            this.btn_barang.Caption = "Data Barang";
            this.btn_barang.Id = 3;
            this.btn_barang.LargeGlyph = global::TugasAkhirSIM.Properties.Resources.goods;
            this.btn_barang.Name = "btn_barang";
            this.btn_barang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_barang_ItemClick);
            // 
            // btn_penjualan
            // 
            this.btn_penjualan.Caption = "Penjualan";
            this.btn_penjualan.Glyph = global::TugasAkhirSIM.Properties.Resources.penjualan;
            this.btn_penjualan.Id = 5;
            this.btn_penjualan.LargeGlyph = global::TugasAkhirSIM.Properties.Resources.penjualan;
            this.btn_penjualan.Name = "btn_penjualan";
            this.btn_penjualan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_penjualan_ItemClick);
            // 
            // btn_pembayaran
            // 
            this.btn_pembayaran.Caption = "Pembayaran";
            this.btn_pembayaran.Id = 6;
            this.btn_pembayaran.LargeGlyph = global::TugasAkhirSIM.Properties.Resources.pembayaran;
            this.btn_pembayaran.Name = "btn_pembayaran";
            this.btn_pembayaran.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_pembayaran_ItemClick);
            // 
            // btn_rpt_barang
            // 
            this.btn_rpt_barang.Caption = "Data Barang";
            this.btn_rpt_barang.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_barang.Glyph")));
            this.btn_rpt_barang.Id = 7;
            this.btn_rpt_barang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_barang.LargeGlyph")));
            this.btn_rpt_barang.Name = "btn_rpt_barang";
            this.btn_rpt_barang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_rpt_barang_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Penjualan Per Karyawan";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Penjualan";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btn_rpt_konsumen
            // 
            this.btn_rpt_konsumen.Caption = "Konsumen";
            this.btn_rpt_konsumen.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_konsumen.Glyph")));
            this.btn_rpt_konsumen.Id = 10;
            this.btn_rpt_konsumen.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_konsumen.LargeGlyph")));
            this.btn_rpt_konsumen.Name = "btn_rpt_konsumen";
            this.btn_rpt_konsumen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_rpt_konsumen_ItemClick);
            // 
            // btn_rpt_barang_satuan
            // 
            this.btn_rpt_barang_satuan.Caption = "Barang Per Satuan";
            this.btn_rpt_barang_satuan.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_barang_satuan.Glyph")));
            this.btn_rpt_barang_satuan.Id = 11;
            this.btn_rpt_barang_satuan.Name = "btn_rpt_barang_satuan";
            this.btn_rpt_barang_satuan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_rpt_barang_satuan_ItemClick);
            // 
            // btn_rpt_barang_jenis
            // 
            this.btn_rpt_barang_jenis.Caption = "Barang Per Jenis";
            this.btn_rpt_barang_jenis.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_barang_jenis.Glyph")));
            this.btn_rpt_barang_jenis.Id = 12;
            this.btn_rpt_barang_jenis.Name = "btn_rpt_barang_jenis";
            this.btn_rpt_barang_jenis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_rpt_barang_jenis_ItemClick);
            // 
            // btn_rpt_karyawan
            // 
            this.btn_rpt_karyawan.Caption = "Karyawan";
            this.btn_rpt_karyawan.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_karyawan.Glyph")));
            this.btn_rpt_karyawan.Id = 13;
            this.btn_rpt_karyawan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_karyawan.LargeGlyph")));
            this.btn_rpt_karyawan.Name = "btn_rpt_karyawan";
            this.btn_rpt_karyawan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_rpt_karyawan_ItemClick);
            // 
            // btn_konsumen_periode
            // 
            this.btn_konsumen_periode.Caption = "Konsumen Per Periode";
            this.btn_konsumen_periode.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_konsumen_periode.Glyph")));
            this.btn_konsumen_periode.Id = 14;
            this.btn_konsumen_periode.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_konsumen_periode.LargeGlyph")));
            this.btn_konsumen_periode.Name = "btn_konsumen_periode";
            this.btn_konsumen_periode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_konsumen_periode_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Kode Karyawan : ";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbl_kd_karyawan
            // 
            this.lbl_kd_karyawan.Caption = "-";
            this.lbl_kd_karyawan.Id = 2;
            this.lbl_kd_karyawan.Name = "lbl_kd_karyawan";
            this.lbl_kd_karyawan.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Nama : ";
            this.barStaticItem3.Id = 3;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbl_nama
            // 
            this.lbl_nama.Caption = "-";
            this.lbl_nama.Id = 4;
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem5
            // 
            this.barStaticItem5.Caption = "Hak Akses : ";
            this.barStaticItem5.Id = 5;
            this.barStaticItem5.Name = "barStaticItem5";
            this.barStaticItem5.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbl_hak_akses
            // 
            this.lbl_hak_akses.Caption = "-";
            this.lbl_hak_akses.Id = 6;
            this.lbl_hak_akses.Name = "lbl_hak_akses";
            this.lbl_hak_akses.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btn_login2
            // 
            this.btn_login2.Caption = "Login";
            this.btn_login2.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_login2.Glyph")));
            this.btn_login2.Id = 7;
            this.btn_login2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_login2.LargeGlyph")));
            this.btn_login2.Name = "btn_login2";
            this.btn_login2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_login2_ItemClick);
            // 
            // btn_logout2
            // 
            this.btn_logout2.Caption = "Logout";
            this.btn_logout2.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_logout2.Glyph")));
            this.btn_logout2.Id = 8;
            this.btn_logout2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_logout2.LargeGlyph")));
            this.btn_logout2.Name = "btn_logout2";
            this.btn_logout2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_logout_ItemClick);
            // 
            // page_master
            // 
            this.page_master.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.group_master,
            this.group_barang,
            this.ribbonPageGroup2});
            this.page_master.Name = "page_master";
            this.page_master.Text = "Master";
            // 
            // group_master
            // 
            this.group_master.ItemLinks.Add(this.btn_karyawan);
            this.group_master.ItemLinks.Add(this.btn_konsumen, true);
            this.group_master.Name = "group_master";
            this.group_master.Text = "Master";
            // 
            // group_barang
            // 
            this.group_barang.ItemLinks.Add(this.btn_barang);
            this.group_barang.Name = "group_barang";
            this.group_barang.Text = "Barang";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_login2);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_logout2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Login";
            // 
            // page_transaksi
            // 
            this.page_transaksi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.page_transaksi.Name = "page_transaksi";
            this.page_transaksi.Text = "Transaksi";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_penjualan);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_pembayaran, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Transaksi";
            // 
            // page_laporan
            // 
            this.page_laporan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup6,
            this.ribbonPageGroup5});
            this.page_laporan.Name = "page_laporan";
            this.page_laporan.Text = "Laporan";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_rpt_konsumen);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_konsumen_periode);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_rpt_karyawan, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Master";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_rpt_barang);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_rpt_barang_satuan, true);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_rpt_barang_jenis);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Barang";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Transaksi";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.lbl_kd_karyawan);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem3);
            this.ribbonStatusBar.ItemLinks.Add(this.lbl_nama);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem5);
            this.ribbonStatusBar.ItemLinks.Add(this.lbl_hak_akses);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 453);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(941, 23);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 476);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainMenu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_master;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_master;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btn_karyawan;
        private DevExpress.XtraBars.BarButtonItem btn_konsumen;
        private DevExpress.XtraBars.BarButtonItem btn_barang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_barang;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_transaksi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_laporan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_penjualan;
        private DevExpress.XtraBars.BarButtonItem btn_pembayaran;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btn_rpt_barang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_rpt_konsumen;
        private DevExpress.XtraBars.BarButtonItem btn_rpt_barang_satuan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btn_rpt_barang_jenis;
        private DevExpress.XtraBars.BarButtonItem btn_rpt_karyawan;
        private DevExpress.XtraBars.BarButtonItem btn_konsumen_periode;
        private DevExpress.XtraBars.BarButtonItem btn_login;
        private DevExpress.XtraBars.BarButtonItem btn_logout;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem lbl_kd_karyawan;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem lbl_nama;
        private DevExpress.XtraBars.BarStaticItem barStaticItem5;
        private DevExpress.XtraBars.BarStaticItem lbl_hak_akses;
        private DevExpress.XtraBars.BarButtonItem btn_login2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_logout2;
    }
}