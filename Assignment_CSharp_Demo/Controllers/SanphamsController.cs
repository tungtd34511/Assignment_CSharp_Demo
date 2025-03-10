﻿using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Interfaces;
using Data.Repositories.Implementations;
using Data.ModelsClass;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_CSharp_Demo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanphamController : ControllerBase
    {
        private readonly IRepositories<Sanpham> _SanphamRepositories;
        public SanphamController()
        {
            _SanphamRepositories = new AllRepositories<Sanpham>();
        }
        // GET: api/<ChucvuController>
        [HttpGet]
        public Task<IEnumerable<Sanpham>> Get()
        {
            return _SanphamRepositories.GetAllAsync();
        }

        // GET api/<ChucvuController>/5
        [HttpGet("{id}")]
        public Task<Sanpham> Get(Guid id)
        {
            return _SanphamRepositories.GetAsync(id);
        }

        // POST api/<ChucvuController>
        [HttpPost]
        public void Post([FromBody] Sanpham sanpham)
        {
            _SanphamRepositories.AddOneAsyn(sanpham);
        }

        // PUT api/<ChucvuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Sanpham sanpham)
        {
            _SanphamRepositories.UpdateOneAsyn(sanpham);
        }

        // DELETE api/<ChucvuController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var x = _SanphamRepositories.GetAsync(id).Result;
            _SanphamRepositories.DeleteOneAsyn(x);
        }
    }
}
