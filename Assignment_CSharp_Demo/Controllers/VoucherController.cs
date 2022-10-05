using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Interfaces;
using Data.Repositories.Implementations;
using Data.ModelsClass;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IRepositories<Voucher> _VoucherRepositories;
        public VoucherController()
        {
            _VoucherRepositories = new AllRepositories<Voucher>();
        }
        // GET: api/<ChucvuController>
        [HttpGet]
        public Task<IEnumerable<Voucher>> Get()
        {
            return _VoucherRepositories.GetAllAsync();
        }

        // GET api/<ChucvuController>/5
        [HttpGet("{id}")]
        public Task<Voucher> Get(Guid id)
        {
            return _VoucherRepositories.GetAsync(id);
        }

        // POST api/<ChucvuController>
        [HttpPost]
        public void Post([FromBody] Voucher voucher)
        {
            _VoucherRepositories.AddOneAsyn(voucher);
        }

        // PUT api/<ChucvuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Voucher voucher)
        {
            _VoucherRepositories.UpdateOneAsyn(voucher);
        }

        // DELETE api/<ChucvuController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var x = _VoucherRepositories.GetAsync(id).Result;
            _VoucherRepositories.DeleteOneAsyn(x);
        }
    }
}
