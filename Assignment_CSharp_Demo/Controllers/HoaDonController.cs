using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Interfaces;
using Data.Repositories.Implementations;
using Data.ModelsClass;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoadonController : ControllerBase
    {
        private readonly IRepositories<Hoadon> _HoadonRepositories;
        public HoadonController()
        {
            _HoadonRepositories = new AllRepositories<Hoadon>();
        }
        // GET: api/<ChucvuController>
        [HttpGet]
        public Task<IEnumerable<Hoadon>> Get()
        {
            return _HoadonRepositories.GetAllAsync();
        }

        // GET api/<ChucvuController>/5
        [HttpGet("{id}")]
        public Task<Hoadon> Get(Guid id)
        {
            return _HoadonRepositories.GetAsync(id);
        }

        // POST api/<ChucvuController>
        [HttpPost]
        public void Post([FromBody] Hoadon hoadon)
        {
            _HoadonRepositories.AddOneAsyn(hoadon);
        }

        // PUT api/<ChucvuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Hoadon hoadon)
        {
            _HoadonRepositories.UpdateOneAsyn(hoadon);
        }

        // DELETE api/<ChucvuController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var x = _HoadonRepositories.GetAsync(id).Result;
            _HoadonRepositories.DeleteOneAsyn(x);
        }
    }
}
