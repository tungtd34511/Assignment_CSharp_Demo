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
    internal class KhachhangConfiguration : IEntityTypeConfiguration<Khachhang>
    {
        public void Configure(EntityTypeBuilder<Khachhang> builder)
        {
            builder.ToTable("Khachhang");
            builder.HasKey(x => x.Id);
        }
    }
}
