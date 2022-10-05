using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ModelsClass
{
    public class Chitietchucvu
    {
        public Guid ChucvuId { get; set; }
        public Chucvu Chucvu { get; set; }
        public Guid NhanvienId { get; set; }
        public Nhanvien Nhanvien { get; set; }
    }
}
