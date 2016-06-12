using System;
using System.Collections.Generic;

namespace TugasAkhirSIM.Models
{
    public partial class detail_penjualan
    {
        public Nullable<int> kd_detail_penjualan { get; set; }
        public string no_faktur { get; set; }
        public string kd_barang { get; set; }
        public Nullable<int> harga { get; set; }
        public Nullable<int> jumlah { get; set; }
        public Nullable<int> total { get; set; }

        public virtual barang barang { get; set; }
        public virtual penjualan penjualan { get; set; }
    }
}
