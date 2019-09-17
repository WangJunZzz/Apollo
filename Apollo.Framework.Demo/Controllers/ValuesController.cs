using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Apollo.Framework.Demo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return ConfigurationManager.AppSettings["Test"];
        }
    }
}
