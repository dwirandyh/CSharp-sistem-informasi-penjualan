using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace TugasAkhirSIM.Models.Mapping
{
    public class pembayaranMap : EntityTypeConfiguration<pembayaran>
    {
        public pembayaranMap()
        {
            // Primary Key
            this.HasKey(t => t.kd_pembayaran);

            // Properties
            this.Property(t => t.no_faktur)
                .HasMaxLength(19);

            this.Property(t => t.kd_karyawan)
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("pembayaran", "sim_penjualan");
            this.Property(t => t.kd_pembayaran).HasColumnName("kd_pembayaran");
            this.Property(t => t.no_faktur).HasColumnName("no_faktur");
            this.Property(t => t.tgl).HasColumnName("tgl");
            this.Property(t => t.kd_karyawan).HasColumnName("kd_karyawan");
            this.Property(t => t.total_bayar).HasColumnName("total_bayar");
            this.Property(t => t.dibayar).HasColumnName("dibayar");
            this.Property(t => t.kembali).HasColumnName("kembali");

            // Relationships
            this.HasOptional(t => t.karyawan)
                .WithMany(t => t.pembayarans)
                .HasForeignKey(d => d.kd_karyawan);
            this.HasOptional(t => t.penjualan)
                .WithMany(t => t.pembayarans)
                .HasForeignKey(d => d.no_faktur);
        }
    }


}
