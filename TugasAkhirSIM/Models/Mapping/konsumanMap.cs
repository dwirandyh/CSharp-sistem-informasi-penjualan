using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TugasAkhirSIM.Models.Mapping
{
    public class konsumanMap : EntityTypeConfiguration<konsumen>
    {
        public konsumanMap()
        {
            // Primary Key
            this.HasKey(t => t.kd_konsumen);

            // Properties
            this.Property(t => t.kd_konsumen)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.nama)
                .HasMaxLength(50);

            this.Property(t => t.alamat)
                .HasMaxLength(65535);

            this.Property(t => t.no_telepon)
                .HasMaxLength(20);

            this.Property(t => t.email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("konsumen", "sim_penjualan");
            this.Property(t => t.kd_konsumen).HasColumnName("kd_konsumen");
            this.Property(t => t.nama).HasColumnName("nama");
            this.Property(t => t.alamat).HasColumnName("alamat");
            this.Property(t => t.no_telepon).HasColumnName("no_telepon");
            this.Property(t => t.email).HasColumnName("email");
        }
    }
}
