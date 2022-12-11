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

        [Route("api/Roles")]
        [HttpPost]
        public HttpResponseMessage Add(RoleDTO obj)
        {
            var data = RoleService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Roles/update")]
        [HttpPost]
        public HttpResponseMessage Update(RoleDTO obj)
        {
            var data = RoleService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Role/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = RoleService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
