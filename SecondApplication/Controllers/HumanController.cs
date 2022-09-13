using Microsoft.AspNetCore.Mvc;
using SecondApplication.Domains;
using SecondApplication.Repository;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HumanInfoApplication.Controllers
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
        public void Create(Human human) => Storages.HumanStorage.Create(human);

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
    }
}
