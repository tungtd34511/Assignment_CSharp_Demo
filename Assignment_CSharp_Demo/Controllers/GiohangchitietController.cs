using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Interfaces;
using Data.Repositories.Implementations;
using Data.ModelsClass;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiohangchitietController : ControllerBase
    {
        private readonly IRepositories<Giohangchitiet> _giohangchitietRepositories;
        public GiohangchitietController()
        {
            _giohangchitietRepositories = new AllRepositories<Giohangchitiet>();
        }
        // GET: api/<ChucvuController>
        [HttpGet]
        public Task<IEnumerable<Giohangchitiet>> Get()
        {
            return _giohangchitietRepositories.GetAllAsync();
        }

        // GET api/<ChucvuController>/5
        [HttpGet("{id}")]
        public Task<Giohangchitiet> Get(Guid id)
        {
            return _giohangchitietRepositories.GetAsync(id);
        }

        // POST api/<ChucvuController>
        [HttpPost]
        public void Post([FromBody] Giohangchitiet giohangchitiet)
        {
            _giohangchitietRepositories.AddOneAsyn(giohangchitiet);
        }

        // PUT api/<ChucvuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Giohangchitiet giohangchitiet)
        {
            _giohangchitietRepositories.UpdateOneAsyn(giohangchitiet);
        }

        // DELETE api/<ChucvuController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var x = _giohangchitietRepositories.GetAsync(id).Result;
            _giohangchitietRepositories.DeleteOneAsyn(x);
        }
    }
}
