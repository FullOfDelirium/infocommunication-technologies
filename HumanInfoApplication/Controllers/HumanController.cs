using Microsoft.AspNetCore.Mvc;
using HumanInfoApplication.Domains;
using HumanInfoApplication.Repository;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HumanInfoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanController : ControllerBase
    {
        //string address = "https://localhost:7215";

        // GET api/<HumanController>/5
        [HttpGet]
        public Human Read(int humanId)
        {
             return Storages.HumanStorage.Read(humanId);
        }

        // POST api/<HumanController>
        [HttpPost]
        public Human Update(int ID, Human human)
        {
            return Storages.HumanStorage.Update(ID, human);
        }

        // PUT api/<HumanController>/5
        [HttpPut]
        public Human Create(Human human)
        {
            Storages.HumanStorage.Create(human);
            return human;
        }

        // DELETE api/<HumanController>/5
        [HttpDelete("{id}")]
        public bool Delete(int ID)
        {
            return Storages.HumanStorage.Delete(ID);
        }
    }
}
