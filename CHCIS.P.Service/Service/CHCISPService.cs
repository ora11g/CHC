using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ServiceModel;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.Practices.Unity;
using Serialize.Linq.Nodes;
using Xx.His.Contract.Message;
using Xx.His.Core;
using Xx.His.Service;
using CHCIS.P.Contract.Message;
using CHCIS.P.Contract.Service;

namespace CHCIS.P.Service
{    
    [GlobalExceptionHandlerBehaviourAttribute(typeof(GlobalExceptionHandler))]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CHCISPService : Profile, ICHCISPService
    {
        private bool disposed = false;

        #region Properties
        [Dependency]
        public IPatientService patientService 
        {
            get { return IoCContainer.Instance.Resolve<IPatientService>(); } 
        }

        [Dependency]
        public IInvoiceDtlService invoiceDtlService
        {
            get { return IoCContainer.Instance.Resolve<IInvoiceDtlService>(); }
        }

        [Dependency]
        public IItemService itemService
        {
            get { return IoCContainer.Instance.Resolve<IItemService>(); }
        }

        public virtual ICommandWrapper CommandWrapper
        {
            get { return IoCContainer.Instance.Resolve<ICommandWrapper>(); }
        }        
        #endregion

        #region 患者信息
        public Response<PatientDto> GetPatientByID(string patientID)
        {
            var response = new Response<PatientDto>();
            
            response.Body.Result = patientService.Retrieve(int.Parse(patientID));

            return response;
        }

        public Response<PatientDto> AddNewPatient(PatientDto patientDTO)
        {
            var response = new Response<PatientDto>();

            response.Body.Result = patientService.Create(patientDTO);

            return response;
        }

        public Response<PatientDto> UpdatePatient(PatientDto patientDTO)
        {
            var response = new Response<PatientDto>();

            patientService.Update(patientDTO);

            response.Body.Result = patientDTO;

            return response;
        }
        #endregion

        #region 项目信息
        public Response<ItemDto> GetItemByID(string itemID)
        {
            Response<ItemDto> response = new Response<ItemDto>();

            response.Body.Result = itemService.Retrieve(int.Parse(itemID));

            return response;
        }

        public Response<ItemDto> AddNewItem(ItemDto itemDTO)
        {
            Response<ItemDto> response = new Response<ItemDto>();

            response.Body.Result = itemService.Create(itemDTO);

            return response;
        }

        public Response<ItemDto> UpdateItem(ItemDto itemDTO)
        {
            Response<ItemDto> response = new Response<ItemDto>();
            
            itemService.Update(itemDTO);

            response.Body.Result = itemDTO;

            return response;
        }
        #endregion

        #region 发票信息

        #endregion

        #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (CommandWrapper != null)
                    {
                        CommandWrapper.Dispose();
                    }
                }
            }

            this.disposed = true;
        }
        #endregion

    }
}