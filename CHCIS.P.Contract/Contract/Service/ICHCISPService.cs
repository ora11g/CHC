using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CHCIS.P.Contract.Message;
using Xx.His.Contract.Service;
using System.ServiceModel.Activation;
using System.ComponentModel;
using Xx.His.Contract.Message;

namespace CHCIS.P.Contract.Service
{
    [ServiceContract]
    public interface ICHCISPService : IServiceBase
    {
        #region 患者信息
        [OperationContract, Description("根据标识号获取患者信息")]
        [WebGet(UriTemplate = "/GetPatientByID/{PatientID}", ResponseFormat = WebMessageFormat.Json)]
        Response<PatientDto> GetPatientByID(string patientID);
        
        [OperationContract, Description("新增患者信息")]
        [WebInvoke(Method = "POST", UriTemplate = "/AddNewPatient", ResponseFormat = WebMessageFormat.Json)]
        Response<PatientDto> AddNewPatient(PatientDto patientDTO);
        
        [OperationContract, Description("更新患者信息")]
        [WebInvoke(Method = "POST", UriTemplate = "/UpdatePatient", ResponseFormat = WebMessageFormat.Json)]
        Response<PatientDto> UpdatePatient(PatientDto patientDTO);
        #endregion

        #region 项目信息
        [OperationContract, Description("根据标识号获取项目信息")]
        [WebGet(UriTemplate = "/GetItemByID/{ItemID}", ResponseFormat = WebMessageFormat.Json)]
        Response<ItemDto> GetItemByID(string itemID);

        [OperationContract, Description("新增项目信息")]
        [WebInvoke(Method = "POST", UriTemplate = "/AddNewItem", ResponseFormat = WebMessageFormat.Json)]
        Response<ItemDto> AddNewItem(ItemDto itemDTO);

        [OperationContract, Description("更新项目信息")]
        [WebInvoke(Method = "POST", UriTemplate = "/UpdateItem", ResponseFormat = WebMessageFormat.Json)]
        Response<ItemDto> UpdateItem(ItemDto itemDTO);
        #endregion

        #region 发票信息
        //[OperationContract, Description("根据标识号获取项目信息")]
        //[WebGet(UriTemplate = "/GetItemByID/{ItemID}", ResponseFormat = WebMessageFormat.Json)]
        //Response<PatientDTO> GetInvoiceByID(string itemID);

        //[OperationContract, Description("新增患者信息")]
        //[WebInvoke(Method = "POST", UriTemplate = "/AddNewItem", ResponseFormat = WebMessageFormat.Json)]
        //Response<PatientDTO> AddNewItem(ItemDTO itemDTO);

        //[OperationContract, Description("更新患者信息")]
        //[WebInvoke(Method = "POST", UriTemplate = "/UpdateItem", ResponseFormat = WebMessageFormat.Json)]
        //Response<PatientDTO> UpdateItem(ItemDTO itemDTO);
        #endregion

        #region 基础信息

        #endregion
    }    
}