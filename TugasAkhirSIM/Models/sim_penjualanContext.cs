using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TugasAkhirSIM.Models.Mapping;

namespace TugasAkhirSIM.Models
{
    public partial class sim_penjualanContext : DbContext
    {
        static sim_penjualanContext()
        {
            Database.SetInitializer<sim_penjualanContext>(null);
        }

        public sim_penjualanContext()
            : base("Name=sim_penjualanContext")
        {
            // menonaktifkan lazy loading
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<barang> barangs { get; set; }
        public DbSet<detail_penjualan> detail_penjualan { get; set; }
        public DbSet<karyawan> karyawans { get; set; }
        public DbSet<konsumen> konsumen { get; set; }
        public DbSet<penjualan> penjualans { get; set; }
        public DbSet<pembayaran> pembayarans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new barangMap());
            modelBuilder.Configurations.Add(new detail_penjualanMap());
            modelBuilder.Configurations.Add(new karyawanMap());
            modelBuilder.Configurations.Add(new konsumanMap());
            modelBuilder.Configurations.Add(new penjualanMap());
            modelBuilder.Configurations.Add(new pembayaranMap());
        }
    }
}
