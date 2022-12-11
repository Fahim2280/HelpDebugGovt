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
    public class UserToRoleController : ApiController
    {
        [Route("api/UserToRoles")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserToRoleService.GetUserToRoles();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/UserToRoles/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = UserToRoleService.GetUserToRoles();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/UserToRoles/add")]
        [HttpPost]
        public HttpResponseMessage Add(UserToRoleDTO obj)
        {
            var data = UserToRoleService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/UserToRoles/update")]
        [HttpPost]
        public HttpResponseMessage Update(UserToRoleDTO obj)
        {
            var data = UserToRoleService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/UserToRoles/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = UserToRoleService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
