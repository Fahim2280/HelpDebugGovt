using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HelpDebugGovtAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class TokenController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginDTO login)
        {
            var token = TokenService.Authenticate(login.Email, login.Password);
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Usernot found");

        }
    }
}
