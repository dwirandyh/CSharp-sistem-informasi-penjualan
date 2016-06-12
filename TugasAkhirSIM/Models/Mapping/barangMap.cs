using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TugasAkhirSIM.Models.Mapping
{
    public class barangMap : EntityTypeConfiguration<barang>
    {
        public barangMap()
        {
            // Primary Key
            this.HasKey(t => t.kd_barang);

            // Properties
            this.Property(t => t.kd_barang)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.nama)
                .HasMaxLength(50);

            this.Property(t => t.satuan)
                .HasMaxLength(20);

            this.Property(t => t.jenis)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("barang", "sim_penjualan");
            this.Property(t => t.kd_barang).HasColumnName("kd_barang");
            this.Property(t => t.nama).HasColumnName("nama");
            this.Property(t => t.harga).HasColumnName("harga");
            this.Property(t => t.satuan).HasColumnName("satuan");
            this.Property(t => t.jenis).HasColumnName("jenis");
            this.Property(t => t.stok).HasColumnName("stok");
        }
    }
}
