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
    internal class ChitietchucvuConfiguration : IEntityTypeConfiguration<Chitietchucvu>
    {
        public void Configure(EntityTypeBuilder<Chitietchucvu> builder)
        {
            builder.ToTable("Chitietchucvu");
            builder.HasKey(o => new { o.NhanvienId, o.ChucvuId });
            // Khóa ngoại
            builder.HasOne<Nhanvien>(e => e.Nhanvien)
                .WithMany(c => c.Chitietchucvus)
                .HasForeignKey(c => c.NhanvienId)
                .HasConstraintName("FK_Nhanvien")
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<Chucvu>(e => e.Chucvu)
                .WithMany(c => c.chitietchucvus)
                .HasForeignKey(c => c.ChucvuId)
                .HasConstraintName("FK_Chucvu")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
