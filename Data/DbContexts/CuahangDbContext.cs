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
            base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=TUNGHACK\\SQLEXPRESS;Initial Catalog=Lab5_61;Integrated Security=True"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChitietchucvuConfiguration());
            modelBuilder.ApplyConfiguration(new ChucvuConfiguration());
            modelBuilder.ApplyConfiguration(new GiohangchitietConfiguration());
            modelBuilder.ApplyConfiguration(new GiohangConfiguration());
            modelBuilder.ApplyConfiguration(new HoadonConfiguration());
            modelBuilder.ApplyConfiguration(new KhachhangConfiguration());
            modelBuilder.ApplyConfiguration(new NhanvienConfiguration());
            modelBuilder.ApplyConfiguration(new SanphamConfiguration());
            modelBuilder.ApplyConfiguration(new VoucherConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly
                (Assembly.GetExecutingAssembly());

        }
        public DbSet<Giohang> Giohangs { get; set; }
        public DbSet<Giohangchitiet> Giohangchitiets { get; set; }
        public DbSet<Sanpham> Sanphams { get; set; }
        public DbSet<Chitietchucvu> Chitietchucvus { get; set; }
        public DbSet<Chucvu> Chucvus { get; set; }
        public DbSet<Hoadon> Hoadons { get; set; }
        public DbSet<Khachhang> KhachHangs { get; set; }
        public DbSet<Nhanvien> Nhanviens { get; set; }
        public DbSet<Voucher> Vouchers { get; set; } 
    }
}
