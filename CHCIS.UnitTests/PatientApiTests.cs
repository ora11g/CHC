using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using log4net;
using Xunit;
using CHCIS.P.Contract.Message;

namespace CHCIS.UnitTests
{
    public class PatientApiTests : TestBase
    {
        private const int PATIENT_ID = 12;
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [Fact, Trait("PatientApiTests", "患者接口测试")]
        public void GetPatientById_Test_Method()
        {
            Log.Debug("******************** GetPatientById_Test_Method ************************");
            st.Start();
            string path = string.Format("api/patients/{0}", PATIENT_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<PatientDto>().Result;
            st.Stop();
            Log.DebugFormat("GetPatientById Elapsed: {0} ms.", st.Elapsed.Milliseconds);
            Assert.NotNull(result);
            Assert.Equal(PATIENT_ID, result.ID);
        }

        [Fact, Trait("PatientApiTests", "患者接口测试")]
        public void UpdatePatientById_Test_Method()
        {
            Log.Debug("******************** UpdatePatientById_Test_Method ************************");
            string path = string.Format("api/patients/{0}", PATIENT_ID);
            st.Start();
            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<PatientDto>().Result;
            st.Stop();
            Log.DebugFormat("GetPatientById Elapsed: {0} ms.", st.Elapsed.Milliseconds);

            st.Start();
            result.Name = string.Concat("*** ", "TEST NAME ", DateTime.Now.ToString("HHmmss"), " ***");

            response = webApiHandler.HttpClient.PutAsJsonAsync(string.Format(@"api/patients/{0}", result.ID), result).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);
            st.Stop();
            Log.DebugFormat("UpdatePatientById Elapsed: {0} ms.", st.Elapsed.Milliseconds);

        }

        [Fact, Trait("PatientApiTests", "患者接口测试")]
        public void CreatePatient_Test_Method()
        {
            string path = string.Format("api/patients/{0}", PATIENT_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<PatientDto>().Result;

            result.ID = 0;
            result.Name = string.Concat("*** ", "TEST NAME ", DateTime.Now.ToString("HHmmss"), " ***");

            response = webApiHandler.HttpClient.PostAsJsonAsync(@"api/patients", result).Result;
            
            Assert.True(response.StatusCode == HttpStatusCode.Created);

            result = response.Content.ReadAsAsync<PatientDto>().Result;

            Assert.NotNull(result);
            Assert.NotEqual(PATIENT_ID, result.ID);
        }

        [Fact, Trait("PatientApiTests", "患者接口测试")]
        public void DeletePatientById_Test_Method()
        {
            string path = string.Format("api/patients/{0}", PATIENT_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<PatientDto>().Result;

            result.ID = 0;
            result.Name = string.Concat("*** ", "TEST NAME ", DateTime.Now.ToString("HHmmss"), " ***");

            response = webApiHandler.HttpClient.PostAsJsonAsync(@"api/patients", result).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.Created);

            result = response.Content.ReadAsAsync<PatientDto>().Result;

            response = webApiHandler.HttpClient.DeleteAsync(string.Format(@"api/patients/{0}", result.ID)).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

    }    
}
