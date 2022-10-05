using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ModelsClass
{
    public class Nhanvien
    {
        public Guid Id { get; set; }
        public bool TrangThai { get; set; }
        public Guid SepId { get; set; }
        public Nhanvien Sep { get; set; }
        public IEnumerable<Nhanvien> Nhanviens { get; set; }
        public IEnumerable<Hoadon> Hoadons { get; set; }
        public IEnumerable<Chitietchucvu> Chitietchucvus { get; set; }
    }
}
