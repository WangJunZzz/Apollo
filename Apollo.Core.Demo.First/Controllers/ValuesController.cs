using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Apollo.Core.Demo.First.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public ValuesController(IConfiguration config)
        {
            configuration = config;
        }
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return configuration["ConnectionStrings"].ToString();
        }
    }
}


