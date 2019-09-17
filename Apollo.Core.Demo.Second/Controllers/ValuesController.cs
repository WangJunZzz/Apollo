using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Apollo.Core.Demo.Second.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private IOptions<ConfigMsg> config;

        public ValuesController(IOptions<ConfigMsg> configMsg)
        {
            config = configMsg;
        }

        [HttpGet]
        public int Get()
        {
            return config.Value.request_timeout;
        }
    }
}
