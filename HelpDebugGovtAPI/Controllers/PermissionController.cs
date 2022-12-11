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
    public class PermissionController : ApiController
    {
        [Route("api/Permissions")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = PermissionService.GetPermissions();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Permissions/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = PermissionService.GetPermissions();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Permissions/add")]
        [HttpPost]
        public HttpResponseMessage Add(permissionDTO obj)
        {
            var data = PermissionService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Permissions/update")]
        [HttpPost]
        public HttpResponseMessage Update(permissionDTO obj)
        {
            var data = PermissionService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Permissions/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = PermissionService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
