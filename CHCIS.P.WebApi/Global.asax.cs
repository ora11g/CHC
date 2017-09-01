using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Web.Mvc;
using CHCIS.P.WebApi.Filters;

namespace CHCIS.P.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configuration.Filters.Add(new ControllerExceptionFilterAttribute());

            GlobalConfiguration.Configure(WebApiConfig.Register);
            
            log4net.Config.XmlConfigurator.Configure();            
        }
    }
}
