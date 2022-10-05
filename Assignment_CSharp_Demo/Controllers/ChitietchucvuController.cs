using Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Implementations;
using Data.Repositories.Interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChitietchucvuController : ControllerBase
    {
        private readonly IRepositories<Chitietchucvu> ChitietchucvuRepositories;
        public ChitietchucvuController()
        {
            ChitietchucvuRepositories = new AllRepositories<Chitietchucvu>();
        }
        // GET: api/<ChitietchucvuController>
        [HttpGet]
        public Task<IEnumerable<Chitietchucvu>> Get()
        {
            return ChitietchucvuRepositories.GetAllAsync();
        }

        // GET api/<ChitietchucvuController>/5
        [HttpGet("{id}")]
        public Task<Chitietchucvu> Get(Guid id)
        {
            return ChitietchucvuRepositories.GetAsync(id);
        }

        // POST api/<ChitietchucvuController>
        [HttpPost]
        public void Post([FromBody] Chitietchucvu chitietchucvu)
        {
            ChitietchucvuRepositories.AddOneAsyn(chitietchucvu);
        }

        // PUT api/<ChitietchucvuController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Chitietchucvu chitietchucvu)
        {
            ChitietchucvuRepositories.UpdateOneAsyn(chitietchucvu);
        }

        // DELETE api/<ChitietchucvuController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var x = ChitietchucvuRepositories.GetAsync(id).Result;
            ChitietchucvuRepositories.DeleteOneAsyn(x);
        }
    }
}
