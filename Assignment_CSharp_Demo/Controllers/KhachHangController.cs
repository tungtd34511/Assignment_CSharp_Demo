using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Interfaces;
using Data.Repositories.Implementations;
using Data.ModelsClass;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachhangController : ControllerBase
    {
        private readonly IRepositories<Khachhang> _KhachhangRepositories;
        public KhachhangController()
        {
            _KhachhangRepositories = new AllRepositories<Khachhang>();
        }
        // GET: api/<ChucvuController>
        [HttpGet]
        public Task<IEnumerable<Khachhang>> Get()
        {
            return _KhachhangRepositories.GetAllAsync();
        }

        // GET api/<ChucvuController>/5
        [HttpGet("{id}")]
        public Task<Khachhang> Get(Guid id)
        {
            return _KhachhangRepositories.GetAsync(id);
        }

        // POST api/<ChucvuController>
        [HttpPost]
        public void Post([FromBody] Khachhang khachhang)
        {
            _KhachhangRepositories.AddOneAsyn(khachhang);
        }

        // PUT api/<ChucvuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Khachhang khachhang)
        {
            _KhachhangRepositories.UpdateOneAsyn(khachhang);
        }

        // DELETE api/<ChucvuController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var x = _KhachhangRepositories.GetAsync(id).Result;
            _KhachhangRepositories.DeleteOneAsyn(x);
        }
    }
}
