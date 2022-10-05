using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ModelsClass
{
    public class Voucher
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public double GiamGia { get; set; }
        public IEnumerable<Hoadon> Hoadons { get; set; }
    }
}
