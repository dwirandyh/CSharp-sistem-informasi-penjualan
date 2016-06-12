using System;
using System.Collections.Generic;

namespace TugasAkhirSIM.Models
{
    public partial class konsumen
    {
        public konsumen()
        {
            this.penjualans = new List<penjualan>();
        }

        public string kd_konsumen { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string no_telepon { get; set; }
        public string email { get; set; }
        public virtual ICollection<penjualan> penjualans { get; set; }
    }
}
