using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using CHCIS.P.Domain;
using CHCIS.P.Contract.Message;
using CHCIS.P.Contract.Service;
using CHCIS.P.WebApi.Filters;

namespace CHCIS.P.WebApi.Controllers
{
    [RoutePrefix("api/patients")]    
    public class PatientsController : CommonApiController<IPatientService, BsPatient, PatientDto>
    {     
    }
}
