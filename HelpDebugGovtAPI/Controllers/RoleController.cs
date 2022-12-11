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
    public class RoleController : ApiController
    {
        [Route("api/Roles")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = RoleService.GetRoles();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Roles/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = RoleService.GetRoles();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Role")]
        [HttpPost]
        public HttpResponseMessage Add(RoleService obj)
        {
            var data = RoleService.Get(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
