using Data.DbContexts;
using Data.ModelsClass;
using Data.Repositories.Interfaces;
using MessagePack.Formatters;

namespace Assignment_CSharp_Demo_API.Sevices
{
    public class SanphamsService
    {
        private readonly CuahangDbContext context;
        private readonly IRepositories<Sanpham> repositories;
        public SanphamsService(IRepositories<Sanpham> repositories,
            CuahangDbContext context)
        {
            this.repositories = repositories;
            this.context = context; 
        }

        public Task<IEnumerable<Sanpham>> GetAllSanPham() // Lấy tất
        {
            return repositories.GetAllAsync();
        }
        public Task<Sanpham> GetSanPhamByID(Guid id) // Lấy theo ID
        {
            return repositories.GetAsync(id);
        }
        public async Task<IEnumerable<Sanpham>> SearchSanphamByTen(string name)
        {
            var result = GetAllSanPham().Result.Where(c => c.Ten.Contains(name));
            return  result.ToList();
        }

        public async Task<IEnumerable<Sanpham>> SearchSanphamKhoangGia(long min, long max)
        {
            var result = GetAllSanPham().Result.Where(c => c.Gia <= max && c.Gia >= min);
            return result.ToList();
        }

        public bool AddNewSanpham(Sanpham sanpham)
        {
            try
            {
                repositories.AddOneAsyn(sanpham);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool AddListSanpham(IEnumerable<Sanpham> sanphams)
        {
            try
            {
                repositories.AddManyAsyn(sanphams);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool UpdateSanpham(Sanpham sanpham)
        {
            try
            {
                repositories.UpdateOneAsyn(sanpham);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool UpdateManySanpham(IEnumerable<Sanpham> sanphams)
        {
            try
            {
                repositories.UpdateManyAsyn(sanphams);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool UpdateTrangthaiSanpham(Guid id)
        {
            try
            {
                var sanpham = context.Sanphams.Find(id);
                sanpham.Trangthai = !sanpham.Trangthai; // Đổi trạng thái
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public bool DeleteSanpham(Guid id)
        {  
            try
            {
                var sanpham = repositories.GetAsync(id).Result;
                if (sanpham == null) return false;
                repositories.DeleteOneAsyn(sanpham);
                return true;
            }
            catch (Exception)
            {
                return false;                    
            }
        }
        public bool DeleteNhieuSanpham(IEnumerable<Sanpham> sanphams)
        {
            try
            {
                repositories.DeleteManyAsyn(sanphams);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
