using System;
using System.ServiceModel;
using Xx.His.Service;
using CHCIS.P.Contract.Service;
using CHCIS.P.Contract.Message;
using CHCIS.P.Domain;

namespace CHCIS.P.Service
{
    [GlobalExceptionHandlerBehaviourAttribute(typeof(GlobalExceptionHandler))]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class InvoiceDtlService : AbstractService<InInvoiceDtl, InvoiceDtlDto>, IInvoiceDtlService
    {
        [Obsolete]
        protected override void Configure()
        {
            CreateMap<InInvoiceDtl, InvoiceDtlDto>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));
        }
    }
}
