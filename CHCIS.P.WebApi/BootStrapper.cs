using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Microsoft.Practices.Unity;
using System.Reflection;
using CHCIS.P.Service;
using CHCIS.P.Contract.Service;
using Xx.His.Core;
using CHCIS.P.Domain;
using Xx.His.Utils;

namespace CHCIS.P.WebApi
{
    public class BootStrapper
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private const string DefaultConnectionString = "CHCIS.P.API";

        /// <summary>
        /// Build unity container
        /// </summary>
        /// <param name="connectionString">The name of connectionstring in configuration</param>
        /// <returns></returns>
        public static IUnityContainer BuildContainer(string connectionString)
        {
            var mappedToTypeAssembly = typeof(CHCISPService).Assembly;

            // Automapper configurations
            MapperConfiguration.Configure(mappedToTypeAssembly);

            // Unity container configurations
            return ContainerBuilder.Build<CHCIS_P_Context>(connectionString)
                .RegisterTypes(typeof(ICHCISPService).Assembly, mappedToTypeAssembly)
                .RegisterType<ICHCISPService, CHCISPService>();            
        }

        public static IUnityContainer BuildContainer()
        {
            return BuildContainer(DefaultConnectionString);
        }
    }
}