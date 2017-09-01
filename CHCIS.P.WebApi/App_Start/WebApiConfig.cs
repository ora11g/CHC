using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Formatting;
using CHCIS.P.WebApi.Filters;

namespace CHCIS.P.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            RouteConfig.RegisterRoutes(config);
            
            var unityContainer = BootStrapper.BuildContainer();

            config.DependencyResolver = new UnityResolver(unityContainer);
            config.Filters.Add(new ValidateModelAttribute());

            config.Filters.Add(new ControllerExceptionFilterAttribute());
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            ResponseFormatConfiguration(config);
        }

        private static void ResponseFormatConfiguration(HttpConfiguration config)
        {                        
            var xmlFormatter = config.Formatters.XmlFormatter;
            var jsonFormatter = config.Formatters.JsonFormatter;
            var jsonSerializerSettings = jsonFormatter.SerializerSettings;

            xmlFormatter.SupportedMediaTypes.Clear();
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            jsonSerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;           
            jsonSerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            jsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("ResponseFormat", "json", "application/json"));
            xmlFormatter.MediaTypeMappings.Add(new QueryStringMapping("ResponseFormat", "xml", "application/xml"));
        }
    }
}
