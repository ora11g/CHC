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
    public class ItemServiceTests : TestBase
    {
        private const int ITEM_ID = 816148;

        [Fact, Trait("ItemServiceTests", "项目接口测试")]
        public void GetItemById_Test_Method()
        {
            string path = string.Format("api/items/{0}", ITEM_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<ItemDto>().Result;
            Assert.NotNull(result);
            Assert.Equal(ITEM_ID, result.ID);
        }

        [Fact, Trait("ItemServiceTests", "项目接口测试")]
        public void UpdateItemById_Test_Method()
        {
            string path = string.Format("api/items/{0}", ITEM_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<ItemDto>().Result;
            Assert.NotNull(result);
            Assert.Equal(ITEM_ID, result.ID);

            result.Memo = string.Concat("*** ", "MEMO", DateTime.Now.ToString("HHmmss"), " ***");

            response = webApiHandler.HttpClient.PutAsJsonAsync(string.Format(@"api/items/{0}", result.ID), result).Result;
            
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

        [Fact, Trait("ItemServiceTests", "项目接口测试")]
        public void CreateItem_Test_Method()
        {
            string path = string.Format("api/items/{0}", ITEM_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);

            var result = response.Content.ReadAsAsync<ItemDto>().Result;
            Assert.NotNull(result);
            Assert.Equal(ITEM_ID, result.ID);

            result.ID = 0;
            result.Memo = string.Concat("*** ", "MEMO", DateTime.Now.ToString("HHmmss"), " ***");
            result.Code = "C" + DateTime.Now.ToString("MMddHHmmss");
            response = webApiHandler.HttpClient.PostAsJsonAsync(@"api/items", result).Result;

            Assert.True(response.StatusCode == HttpStatusCode.Created);

            var newInvoiceDtlDto = response.Content.ReadAsAsync<ItemDto>().Result;

            Assert.NotNull(newInvoiceDtlDto);
            Assert.NotEqual(ITEM_ID, newInvoiceDtlDto.ID);
        }

        [Fact, Trait("ItemServiceTests", "项目接口测试")]
        public void DeleteItemById_Test_Method()
        {
            string path = string.Format("api/items/{0}", ITEM_ID);

            HttpResponseMessage response = webApiHandler.HttpClient.GetAsync(path).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.OK);            
           
            var result = response.Content.ReadAsAsync<ItemDto>().Result;
            Assert.NotNull(result);
            Assert.Equal(ITEM_ID, result.ID);

            result.ID = 0;
            result.Memo = string.Concat("*** ", "MEMO", DateTime.Now.ToString("HHmmss"), " ***");
            result.Code = "D" + DateTime.Now.ToString("MMddHHmmss");
            response = webApiHandler.HttpClient.PostAsJsonAsync(@"api/items", result).Result;            
            Assert.True(response.StatusCode == HttpStatusCode.Created);
            var newInvoiceDtlDto = response.Content.ReadAsAsync<PatientDto>().Result;

            Assert.NotNull(newInvoiceDtlDto);
            Assert.NotEqual(ITEM_ID, newInvoiceDtlDto.ID);

            response = webApiHandler.HttpClient.DeleteAsync(string.Format(@"api/items/{0}", newInvoiceDtlDto.ID)).Result;

            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }
      
    }
}
