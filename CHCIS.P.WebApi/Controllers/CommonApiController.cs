using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Http.Description;
using System.Text;
using Xx.His.Contract.Message;
using Xx.His.Contract.Service;
using Xx.His.Domain;
using AutoMapper;
using log4net;
using Xx.His.Core;
using Serialize.Linq.Nodes;
using Microsoft.Practices.Unity;
using CHCIS.P.WebApi.Filters;
using CHCIS.P.WebApi.Results;

namespace CHCIS.P.WebApi.Controllers
{
    [Authorize]
    [ControllerExceptionFilter]
    public abstract class CommonApiController<TService, TEntity, TDto> : BaseApiController
        where TService : IGenericService<TDto>
        where TEntity : EntityBase, new()
        where TDto : DtoBase, new()
    {
        #region Private variables
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        [Dependency]
        public TService service { get; set; }

        [HttpGet]
        public virtual IHttpActionResult GetById(int id)
        {
            var result = service.Retrieve(id);

            if (result == null)
            {
                return NotFound();                
            }

            return Ok(result);
        }

        [HttpGet]
        public virtual IHttpActionResult GetAll()
        {       
            var result = service.Retrieve();

            return Ok(result);
        }

        [HttpPost, ValidateModel]
        public virtual HttpResponseMessage Post([FromBody]TDto dto)
        {          
            var result = service.Create(dto);
            var response = Request.CreateResponse(HttpStatusCode.Created, result);
            response.Headers.Location = new Uri(string.Format("{0}/{1}", Request.RequestUri, result.ID));
            
            return response;          
        }

        [HttpPut, ValidateModel]
        public virtual IHttpActionResult Put(int id, [FromBody]TDto dto)
        {
            if (id != dto.ID)
            {
                throw new ArgumentOutOfRangeException("id", string.Format("Invalid id '{0}'", id));                
            }
            
            service.Update(dto);

            return Ok();
        }

        [HttpDelete]
        public virtual IHttpActionResult Delete(int id)
        {
            service.Delete(id);

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            service.Dispose();
        }
    }
}

