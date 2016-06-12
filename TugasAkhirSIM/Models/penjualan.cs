using System;
using System.Collections.Generic;

namespace TugasAkhirSIM.Models
{
    public partial class penjualan
    {
        public penjualan()
        {
            this.detail_penjualans = new List<detail_penjualan>();
            this.pembayarans = new List<pembayaran>();
        }

        public string no_faktur { get; set; }
        public string kd_konsumen { get; set; }
        public string kd_karyawan { get; set; }
        public Nullable<System.DateTime> tgl { get; set; }
        public Nullable<int> total { get; set; }
        public Nullable<int> status { get; set;}
        
        public virtual ICollection<detail_penjualan> detail_penjualans { get; set; }
        public virtual ICollection<pembayaran> pembayarans { get; set; }

        public virtual karyawan karyawan { get; set; }
        public virtual konsumen konsumen { get; set; }
    }
}
