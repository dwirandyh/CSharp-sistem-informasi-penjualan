using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TugasAkhirSIM.Models.Mapping
{
    public class detail_penjualanMap : EntityTypeConfiguration<detail_penjualan>
    {
        public detail_penjualanMap()
        {
            // Primary Key
            this.HasKey(t => t.kd_detail_penjualan);

            // Properties
            this.Property(t => t.no_faktur)
                .HasMaxLength(19);

            this.Property(t => t.kd_barang)
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("detail_penjualan", "sim_penjualan");
            this.Property(t => t.kd_detail_penjualan).HasColumnName("kd_detail_penjualan");
            this.Property(t => t.no_faktur).HasColumnName("no_faktur");
            this.Property(t => t.kd_barang).HasColumnName("kd_barang");
            this.Property(t => t.harga).HasColumnName("harga");
            this.Property(t => t.jumlah).HasColumnName("jumlah");
            this.Property(t => t.total).HasColumnName("total");

            // Relationships
            this.HasOptional(t => t.barang)
                .WithMany(t => t.detail_penjualan)
                .HasForeignKey(d => d.kd_barang);
            this.HasOptional(t => t.penjualan)
                .WithMany(t => t.detail_penjualans)
                .HasForeignKey(d => d.no_faktur);

        }
    }
}
