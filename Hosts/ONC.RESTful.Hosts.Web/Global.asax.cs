using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using ONC.RESTful.Framework.Logging;

namespace ONC.RESTful.Hosts.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            LoggingService.Instance.Initialise();
            //LoggingService.Instance.Log("Inicio módulo de bitácoras.");
        }
    }
}