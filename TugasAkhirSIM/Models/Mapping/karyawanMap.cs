using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TugasAkhirSIM.Models.Mapping
{
    public class karyawanMap : EntityTypeConfiguration<karyawan>
    {
        public karyawanMap()
        {
            // Primary Key
            this.HasKey(t => t.kd_karyawan);

            // Properties
            this.Property(t => t.kd_karyawan)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.nama)
                .HasMaxLength(40);

            this.Property(t => t.alamat)
                .HasMaxLength(65535);

            this.Property(t => t.no_telepon)
                .HasMaxLength(20);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.hak_akses)
                .HasMaxLength(30);

            this.Property(t => t.username)
                .HasMaxLength(30);

            this.Property(t => t.password)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("karyawan", "sim_penjualan");
            this.Property(t => t.kd_karyawan).HasColumnName("kd_karyawan");
            this.Property(t => t.nama).HasColumnName("nama");
            this.Property(t => t.alamat).HasColumnName("alamat");
            this.Property(t => t.hak_akses).HasColumnName("hak_akses");
            this.Property(t => t.no_telepon).HasColumnName("no_telepon");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.password).HasColumnName("password");
        }
    }
}
