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
    internal class ChucvuConfiguration : IEntityTypeConfiguration<Chucvu>
    {
        public void Configure(EntityTypeBuilder<Chucvu> builder)
        {
            builder.ToTable("Chucvu");
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("NEWID()");
        }
    }
}
