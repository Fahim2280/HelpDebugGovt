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
    public class UserController : ApiController
    {
        [Route("api/Users")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserService.GetUsers();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Users/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = UserService.GetUsers();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Users/add")]
        [HttpPost]
        public HttpResponseMessage Add(UserDTO obj)
        {
            var data = UserService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Users/update")]
        [HttpPost]
        public HttpResponseMessage Update(UserDTO obj)
        {
            var data = UserService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Users/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(string id)
        {
            var data = UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
