using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Interfaces;
using Data.Repositories.Implementations;
using Data.ModelsClass;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiohangController : ControllerBase
    {
        private readonly IRepositories<Giohang> _GiohangRepositories;
        public GiohangController()
        {
            _GiohangRepositories = new AllRepositories<Giohang>();
        }
        // GET: api/<ChucvuController>
        [HttpGet]
        public Task<IEnumerable<Giohang>> Get()
        {
            return _GiohangRepositories.GetAllAsync();
        }

        // GET api/<ChucvuController>/5
        [HttpGet("{id}")]
        public Task<Giohang> Get(Guid id)
        {
            return _GiohangRepositories.GetAsync(id);
        }

        // POST api/<ChucvuController>
        [HttpPost]
        public void Post([FromBody] Giohang giohang)
        {
            _GiohangRepositories.AddOneAsyn(giohang);
        }

        // PUT api/<ChucvuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Giohang giohang)
        {
            _GiohangRepositories.UpdateOneAsyn(giohang);
        }

        // DELETE api/<ChucvuController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var x = _GiohangRepositories.GetAsync(id).Result;
            _GiohangRepositories.DeleteOneAsyn(x);
        }
    }
}
