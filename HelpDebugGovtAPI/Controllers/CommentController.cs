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
    public class CommentController : ApiController
    {
        [Route("api/Comments")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = CommentService.GetComments();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Comments/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = CommentService.GetComments();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Comments/add")]
        [HttpPost]
        public HttpResponseMessage Add(CommentDTO obj)
        {
            var data = CommentService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Comments/update")]
        [HttpPost]
        public HttpResponseMessage Update(CommentDTO obj)
        {
            var data = CommentService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Comments/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = CommentService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
