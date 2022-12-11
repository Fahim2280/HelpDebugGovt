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
    public class LabelController : ApiController
    {
        [Route("api/Labels")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = LabelService.GetLabels();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Labels/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = LabelService.GetLabels();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Labels/add")]
        [HttpPost]
        public HttpResponseMessage Add(LabelDTO obj)
        {
            var data = LabelService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Labels/update")]
        [HttpPost]
        public HttpResponseMessage Update(LabelDTO obj)
        {
            var data = LabelService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Labels/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = LabelService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
