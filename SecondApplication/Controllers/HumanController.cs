using Microsoft.AspNetCore.Mvc;
using SecondApplication.Domains;
using SecondApplication.Repository;
using System.Net;
using System.Text.Json;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HumanInfoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanController : ControllerBase
    {
        //public HumanController(IConfiguration conf)
        //{
        //    var value =     conf.GetValue<string>("Logging:LogLevel:Default");
        //}

        [HttpGet]
        public async Task<Human> GetHumans(int id)
        {
            var client = new HttpClient();
            var responce = await client.GetAsync($"https://localhost:7215/api/Human?humanId={id}");
            var serverData = await responce.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Human>(serverData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
