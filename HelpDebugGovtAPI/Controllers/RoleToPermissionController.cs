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
    public class RoleToPermissionController : ApiController
    {
        [Route("api/RoleToPermissions")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = RoleToPermissionService.GetRoleToPermissions();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/RoleToPermissions/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = RoleToPermissionService.GetRoleToPermissions();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/RoleToPermissions/add")]
        [HttpPost]
        public HttpResponseMessage Add(RoleToPermissionDTO obj)
        {
            var data = RoleToPermissionService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/RoleToPermissions/update")]
        [HttpPost]
        public HttpResponseMessage Update(RoleToPermissionDTO obj)
        {
            var data = RoleToPermissionService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/RoleToPermissions/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = RoleToPermissionService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
