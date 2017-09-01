using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using WebApiClient.NET;
using log4net;

namespace CHCIS.UnitTests
{
    public class TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        protected static readonly WebApiHandler webApiHandler = new WebApiHandler();
     
        protected static readonly Stopwatch st = new Stopwatch();

        static TestBase()
        {           
        }        
    }
}
