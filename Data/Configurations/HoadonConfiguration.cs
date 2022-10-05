using Data.ModelsClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    internal class HoadonConfiguration : IEntityTypeConfiguration<Hoadon>
    {
        public void Configure(EntityTypeBuilder<Hoadon> builder)
        {
            builder.ToTable("Hoadon");
            builder.HasKey(x => x.GiohangId);
            builder.HasOne<Nhanvien>(e => e.Nhanvien)
                .WithMany(c => c.Hoadons)
                .HasForeignKey(c => c.NhanvienId)
                .HasConstraintName("FK_Nhanvien11")
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Khachhang>(e => e.Khachhang)
                .WithMany(c => c.Hoadons)
                .HasForeignKey(c => c.KhachhangId)
                .HasConstraintName("FK_Khachhang")
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Giohang>(s => s.Giohang)
                .WithOne(a => a.Hoadon)
                 .HasForeignKey<Hoadon>(d => d.GiohangId).HasConstraintName("FK")
                .OnDelete(DeleteBehavior.Cascade);
            builder.Property(c => c.Status).HasColumnName("Trangthai").
                HasColumnType("bit").IsRequired();
        }
    }
}
