using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelpDebugGovtAPI.Controllers
{
    public class OrganizationController : ApiController
    {
        [Route("api/Organizations")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = OrganizationService.GetOrganizations();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Organizations/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = OrganizationService.GetOrganizations();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Organization/add")]
        [HttpPost]
        public HttpResponseMessage Add(OrganizationDTO obj)
        {
            var data = OrganizationService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Organization/update")]
        [HttpPost]
        public HttpResponseMessage Update(OrganizationDTO obj)
        {
            var data = OrganizationService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Organization/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = OrganizationService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
