using System;
using System.Collections.Generic;

namespace TugasAkhirSIM.Models
{
    public partial class karyawan
    {
        public karyawan()
        {
            this.penjualans = new List<penjualan>();
            this.pembayarans = new List<pembayaran>();
        }

        public string kd_karyawan { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string no_telepon { get; set; }
        public string email { get; set; }
        public string hak_akses { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public virtual ICollection<penjualan> penjualans { get; set; }
        public virtual ICollection<pembayaran> pembayarans { get; set; }
    }
}
