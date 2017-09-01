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
    public class PatientService : AbstractService<BsPatient, PatientDto>, IPatientService
    {
        [Obsolete]
        protected override void Configure()
        {
            CreateMap<BsPatient, PatientDto>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));
        }
    }
}
