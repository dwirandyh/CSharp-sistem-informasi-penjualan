using System;
using System.Collections.Generic;

namespace TugasAkhirSIM.Models
{
    public partial class barang
    {
        public barang()
        {
            this.detail_penjualan = new List<detail_penjualan>();
        }

        public string kd_barang { get; set; }
        public string nama { get; set; }
        public Nullable<int> harga { get; set; }
        public string satuan { get; set; }
        public string jenis { get; set; }
        public Nullable<int> stok { get; set; }
        
        
        public virtual ICollection<detail_penjualan> detail_penjualan { get; set; }
    }
}
