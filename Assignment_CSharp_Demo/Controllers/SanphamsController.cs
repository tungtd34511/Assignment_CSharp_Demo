using Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanphamsController : ControllerBase
    {
        // GET: api/<SanphamsController>
        [HttpGet]
        [Route("-get-all-sanpham")]
        public IEnumerable<Sanpham> GetAllSanpham()
        {
            // Fake data
            List<Sanpham> sanpham = new List<Sanpham>()
            {
                new Sanpham{Id = Guid.NewGuid(), Gia = 10000, Ten = "Bim bim", Soluong = 22, Trangthai = true},
                new Sanpham{Id = Guid.NewGuid(), Gia = 25000, Ten = "Coke", Soluong = 16, Trangthai = true},
                new Sanpham{Id = Guid.NewGuid(), Gia = 50000, Ten = "Cà pháo", Soluong = 24, Trangthai = true},
                new Sanpham{Id = Guid.NewGuid(), Gia = 14000, Ten = "Sữa", Soluong = 25, Trangthai = true},
                new Sanpham{Id = Guid.NewGuid(), Gia = 25600, Ten = "Thịt", Soluong = 24, Trangthai = false},
                new Sanpham{Id = Guid.NewGuid(), Gia = 25300, Ten = "Đậu", Soluong = 1000, Trangthai = true},
                new Sanpham{Id = Guid.NewGuid(), Gia = 12345, Ten = "Gà", Soluong = 11, Trangthai = true}
            };
            return sanpham;
        }
        // GET api/<SanphamsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SanphamsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SanphamsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SanphamsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
