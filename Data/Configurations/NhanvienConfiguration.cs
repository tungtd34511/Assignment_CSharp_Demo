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
    internal class NhanvienConfiguration : IEntityTypeConfiguration<Nhanvien>
    {
        public void Configure(EntityTypeBuilder<Nhanvien> builder)
        {
            builder.ToTable("Nhanvien");
            builder.HasKey(x => x.Id);
            builder.Property(c => c.TrangThai).HasColumnName("Trangthai").
                HasColumnType("bit").IsRequired();
            builder.HasOne<Nhanvien>(s => s.Sep)
                .WithMany(a => a.Nhanviens)
                 .HasForeignKey(d => d.SepId).HasConstraintName("FK_Sep").OnDelete(DeleteBehavior.NoAction); ;
        }
    }
}
