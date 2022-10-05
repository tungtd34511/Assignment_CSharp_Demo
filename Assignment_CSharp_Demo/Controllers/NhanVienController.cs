using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Interfaces;
using Data.Repositories.Implementations;
using Data.ModelsClass;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanvienController : ControllerBase
    {
        private readonly IRepositories<Nhanvien> _NhanvienRepositories;
        public NhanvienController()
        {
            _NhanvienRepositories = new AllRepositories<Nhanvien>();
        }
        // GET: api/<ChucvuController>
        [HttpGet]
        public Task<IEnumerable<Nhanvien>> Get()
        {
            return _NhanvienRepositories.GetAllAsync();
        }

        // GET api/<ChucvuController>/5
        [HttpGet("{id}")]
        public Task<Nhanvien> Get(Guid id)
        {
            return _NhanvienRepositories.GetAsync(id);
        }

        // POST api/<ChucvuController>
        [HttpPost]
        public void Post([FromBody] Nhanvien nhanvien)
        {
            _NhanvienRepositories.AddOneAsyn(nhanvien);
        }

        // PUT api/<ChucvuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Nhanvien nhanvien)
        {
            _NhanvienRepositories.UpdateOneAsyn(nhanvien);
        }

        // DELETE api/<ChucvuController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var x = _NhanvienRepositories.GetAsync(id).Result;
            _NhanvienRepositories.DeleteOneAsyn(x);
        }
    }
}
