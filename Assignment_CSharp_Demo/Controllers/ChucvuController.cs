using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Interfaces;
using Data.Repositories.Implementations;
using Data.ModelsClass;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucvuController : ControllerBase
    {
        private readonly IRepositories<Chucvu> _chucvuRepositories;
        public ChucvuController()
        {
            _chucvuRepositories = new AllRepositories<Chucvu>();
            _chucvuRepositories.AddOneAsyn(new Chucvu() { Id=Guid.NewGuid(),Ma="CV01",Ten="Quản lý"});
        }
        // GET: api/<ChucvuController>
        [HttpGet]
        public Task<IEnumerable<Chucvu>> Get()
        {
            return _chucvuRepositories.GetAllAsync();
        }

        // GET api/<ChucvuController>/5
        [HttpGet("{id}")]
        public Task<Chucvu> Get(Guid id)
        {
            return _chucvuRepositories.GetAsync(id);
        }

        // POST api/<ChucvuController>
        [HttpPost]
        public void Post([FromBody] Chucvu chucvu)
        {
            _chucvuRepositories.AddOneAsyn(chucvu);
        }

        // PUT api/<ChucvuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Chucvu chucvu)
        {
            _chucvuRepositories.UpdateOneAsyn(chucvu);
        }

        // DELETE api/<ChucvuController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var x = _chucvuRepositories.GetAsync(id).Result;
            _chucvuRepositories.DeleteOneAsyn(x);
        }
    }
}
