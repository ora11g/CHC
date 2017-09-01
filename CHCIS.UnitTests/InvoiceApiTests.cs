using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CHCIS.P.Contract.Message;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CHCIS.UnitTests
{
    public class InvoiceApiTests : TestBase
    {
        private const int INVOICE_DETAIL_ID = 24502;

        [Fact, Trait("InvoiceApiTests", "发票接口测试")]
        public void GetInvoiceDtlById_Test_Method()
        {
            string path = string.Format("api/invoices/{0}", INVOICE_DETAIL_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<InvoiceDtlDto>().Result;

            Assert.NotNull(result);
            Assert.Equal(INVOICE_DETAIL_ID, result.ID);
        }

        [Fact, Trait("InvoiceApiTests", "发票接口测试")]
        public void UpdateInvoiceDtlById_Test_Method()
        {
            string path = string.Format("api/invoices/{0}", INVOICE_DETAIL_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<InvoiceDtlDto>().Result;            
            
            Assert.NotNull(result);
            Assert.Equal(INVOICE_DETAIL_ID, result.ID);

            result.Memo = string.Concat("*** ", "MEMO", DateTime.Now.ToString("HHmmss"), " ***");

            response = webApiHandler.HttpClient.PutAsJsonAsync(string.Format(@"api/invoices/{0}", result.ID), result).Result;
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

        [Fact, Trait("InvoiceApiTests", "发票接口测试")]
        public void CreateInvoiceDtl_Test_Method()
        {
            string path = string.Format("api/invoices/{0}", INVOICE_DETAIL_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<InvoiceDtlDto>().Result;

            Assert.NotNull(result);
            Assert.Equal(INVOICE_DETAIL_ID, result.ID);

            result.ID = 0;
            result.Memo = string.Concat("*** ", "MEMO", DateTime.Now.ToString("HHmmss"), " ***");

            response = webApiHandler.HttpClient.PostAsJsonAsync(@"api/invoices", result).Result;
            Assert.True(response.StatusCode == HttpStatusCode.Created);

            var newInvoiceDtlDto = response.Content.ReadAsAsync<InvoiceDtlDto>().Result;

            Assert.NotNull(newInvoiceDtlDto);
            Assert.NotEqual(INVOICE_DETAIL_ID, newInvoiceDtlDto.ID);
        }

        [Fact, Trait("InvoiceApiTests", "发票接口测试")]
        public void DeleteInvoiceDtlById_Test_Method()
        {
            string path = string.Format("api/invoices/{0}", INVOICE_DETAIL_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<InvoiceDtlDto>().Result;

            Assert.NotNull(result);
            Assert.Equal(INVOICE_DETAIL_ID, result.ID);

            result.ID = 0;
            result.Memo = string.Concat("*** ", "MEMO", DateTime.Now.ToString("HHmmss"), " ***");

            response = webApiHandler.HttpClient.PostAsJsonAsync(@"api/invoices", result).Result;            

            var newInvoiceDtlDto = response.Content.ReadAsAsync<InvoiceDtlDto>().Result;

            Assert.NotNull(newInvoiceDtlDto);
            Assert.NotEqual(INVOICE_DETAIL_ID, newInvoiceDtlDto.ID);

            response = webApiHandler.HttpClient.DeleteAsync(string.Format(@"api/invoices/{0}", newInvoiceDtlDto.ID)).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }
       
    }
}
