using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ModelsClass
{
    public class Hoadon
    {
        public Guid GiohangId { get; set; }
        public Giohang Giohang { get; set; }
        public Guid NhanvienId { get; set; }
        public Nhanvien Nhanvien { get; set; }
        public Guid KhachhangId { get; set; }
        public Khachhang Khachhang { get; set; }
        public DateTime NgayBan { get; set; }
        public decimal TongTien { get; set; }
        public bool Status { get; set; }
    }
}
