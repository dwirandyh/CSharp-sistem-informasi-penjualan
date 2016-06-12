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
using DevExpress.XtraCharts;

namespace TugasAkhirSIM.Views
{
    public partial class FrmDashboard : DevExpress.XtraEditors.XtraForm
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            DataTable dt_pendapatan1 = new DataTable();
            dt_pendapatan1.Columns.Add("tgl", typeof(DateTime));
            dt_pendapatan1.Columns.Add("total", typeof(int));


            DataTable dt_pendapatan2 = new DataTable();
            dt_pendapatan2.Columns.Add("tgl", typeof(DateTime));
            dt_pendapatan2.Columns.Add("total", typeof(int));


            DataTable dt_barang = new DataTable();
            dt_barang.Columns.Add("nama", typeof(string));
            dt_barang.Columns.Add("jumlah", typeof(int));

            DataTable dt_karyawan = new DataTable();
            dt_karyawan.Columns.Add("nama", typeof(string));
            dt_karyawan.Columns.Add("total", typeof(int));

            using (var db = new Models.sim_penjualanContext())
            {
                db.Database.Connection.Open();
                using (var cmd = db.Database.Connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT SUM(total_bayar) AS total,DATE(tgl) AS tgl FROM pembayaran WHERE DATE(tgl) BETWEEN (DATE(NOW()) - INTERVAL 7 DAY) AND DATE(NOW()) GROUP BY DATE(tgl)";
                    cmd.CommandType = CommandType.Text;
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt_pendapatan1.Load(reader);
                    }
                }

                using (var cmd = db.Database.Connection.CreateCommand())
                {
                    cmd.CommandText = string.Format("SELECT SUM(total_bayar) AS total,DATE(tgl) AS tgl FROM pembayaran WHERE month(tgl)= '{0}' and year(tgl) = '{1}' GROUP BY DATE(tgl)", DateTime.Now.Month, DateTime.Now.Year);
                    cmd.CommandType = CommandType.Text;
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt_pendapatan2.Load(reader);
                    }
                }

                using (var cmd = db.Database.Connection.CreateCommand())
                {
                    cmd.CommandText = "select barang.`nama`, sum(detail_penjualan.`jumlah`) as jumlah FROM barang join detail_penjualan on barang.`kd_barang` = detail_penjualan.`kd_barang` group by barang.`kd_barang`";
                    cmd.CommandType = CommandType.Text;
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt_barang.Load(reader);
                    }
                }

                using (var cmd=  db.Database.Connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT karyawan.`nama`, SUM(pembayaran.total_bayar) AS total FROM karyawan JOIN pembayaran ON karyawan.`kd_karyawan` = pembayaran.`kd_karyawan` GROUP BY karyawan.`nama` limit 0,5";
                    cmd.CommandType = CommandType.Text;
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt_karyawan.Load(reader);
                    }
                }
            }

            chart_pendapatan_1.DataSource = dt_pendapatan1;
            chart_pendapatan2.DataSource = dt_pendapatan2;
            chart_persentase.DataSource = dt_barang;
            chart_karyawan.DataSource = dt_karyawan;

        }
    }
}