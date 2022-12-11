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
    public class LabelToLabelToIssueController : ApiController
    {
        [Route("api/LabelToIssues")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = LabelToIssueService.GetLabelToIssues();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/LabelToIssues/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = LabelToIssueService.GetLabelToIssues();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/LabelToIssues/add")]
        [HttpPost]
        public HttpResponseMessage Add(LabelToIssueDTO obj)
        {
            var data = LabelToIssueService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/LabelToIssues/update")]
        [HttpPost]
        public HttpResponseMessage Update(LabelToIssueDTO obj)
        {
            var data = LabelToIssueService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/LabelToIssues/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = LabelToIssueService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
