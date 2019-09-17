using Com.Ctrip.Framework.Apollo;
using Com.Ctrip.Framework.Apollo.Enums;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Apollo.Framework.Demo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static IConfiguration Configuration { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // apollo≈‰÷√
            Configuration = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
           .AddApollo(ConfigurationManager.AppSettings["Apollo.AppId"], ConfigurationManager.AppSettings["Apollo.MetaServer"])
           .AddDefault(ConfigFileFormat.Xml)
           .AddDefault(ConfigFileFormat.Json)
           .AddDefault(ConfigFileFormat.Yml)
           .AddDefault(ConfigFileFormat.Yaml)
           .AddDefault()
           .Build();
        }
    }
}
