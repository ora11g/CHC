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
    public interface IInvoiceDtlService : IGenericService<InvoiceDtlDto>
    {

    }
}
