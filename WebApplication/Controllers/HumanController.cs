using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Domains;
using WebApplication.repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanController : ControllerBase
    {
        // GET: api/<HumanController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HumanController>/5
        [HttpGet("{id}")]
        public Human Read(int ID)
        {
            return Storages.HumanStorage.Read(ID);
        }

        // POST api/<HumanController>
        [HttpPost]
        public bool Create(Human human)
        {
            return Storages.HumanStorage.Create(human);
        }

        // PUT api/<HumanController>/5
        [HttpPut("{id}")]
        public Human Update(int ID, Human human)
        {
            return Storages.HumanStorage.Update(ID, human);
        }

        // DELETE api/<HumanController>/5
        [HttpDelete("{id}")]
        public bool Delete(int ID)
        {
            return Storages.HumanStorage.Delete(ID);
        }

        [HttpPost("SaveToStorage")]
        public void SaveToStorage()
        {
            Storages.HumanStorage.SaveToStorage();
        }

        [HttpGet("LoadFromStorage")]
        public void LoadFromStorage()
        {
            Storages.HumanStorage.LoadFromStorage();
        }
    }
}
