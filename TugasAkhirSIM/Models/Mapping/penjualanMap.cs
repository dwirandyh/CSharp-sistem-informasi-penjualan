using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TugasAkhirSIM.Models.Mapping
{
    public class penjualanMap : EntityTypeConfiguration<penjualan>
    {
        public penjualanMap()
        {
            // Primary Key
            this.HasKey(t => t.no_faktur);

            // Properties
            this.Property(t => t.no_faktur)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.kd_konsumen)
                .HasMaxLength(7);

            this.Property(t => t.kd_karyawan)
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("penjualan", "sim_penjualan");
            this.Property(t => t.no_faktur).HasColumnName("no_faktur");
            this.Property(t => t.kd_konsumen).HasColumnName("kd_konsumen");
            this.Property(t => t.kd_karyawan).HasColumnName("kd_karyawan");
            this.Property(t => t.tgl).HasColumnName("tgl");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.status).HasColumnName("status");

            // Relationships
            this.HasOptional(t => t.karyawan)
                .WithMany(t => t.penjualans)
                .HasForeignKey(d => d.kd_karyawan);
            this.HasOptional(t => t.konsumen)
                .WithMany(t => t.penjualans)
                .HasForeignKey(d => d.kd_konsumen);

        }
    }
}
