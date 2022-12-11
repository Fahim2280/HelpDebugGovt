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
    public class IssueController : ApiController
    {
        [Route("api/Issues")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = IssueService.GetIssues();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Issues/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = IssueService.GetIssues();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Issue/add")]
        [HttpPost]
        public HttpResponseMessage Add(IssueDTO obj)
        {
            var data = IssueService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Issue/update")]
        [HttpPost]
        public HttpResponseMessage Update(IssueDTO obj)
        {
            var data = IssueService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Issue/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = IssueService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
