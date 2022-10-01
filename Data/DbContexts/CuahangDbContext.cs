using Data.Configurations;
using Data.ModelsClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.DbContexts
{
    public class CuahangDbContext : DbContext
    {
        public CuahangDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("..."));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new GiohangchitietConfiguration());
            //modelBuilder.ApplyConfiguration(new SanphamConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly
                (Assembly.GetExecutingAssembly());

        }
        public DbSet<Giohang> Giohangs { get; set; }
        public DbSet<Giohangchitiet> Giohangchitiets { get; set; }
        public DbSet<Sanpham> Sanphams { get; set; }
    }
}
