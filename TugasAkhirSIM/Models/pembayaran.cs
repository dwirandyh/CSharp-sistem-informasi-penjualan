using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasAkhirSIM.Models
{
    public class pembayaran
    {
        public int kd_pembayaran { get; set; }
        public string no_faktur { get; set; }
        public Nullable<System.DateTime> tgl { get; set; }
        public string kd_karyawan { get; set; }
        public Nullable<int> total_bayar { get; set; }
        public Nullable<int> dibayar { get; set; }
        public Nullable<int> kembali { get; set; }

        public virtual karyawan karyawan { get; set; }
        public virtual penjualan penjualan { get; set; }
    }
}
