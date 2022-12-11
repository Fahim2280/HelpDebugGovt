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
    public class FileController : ApiController
    {
        [Route("api/Files")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = FileService.GetFile();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Files/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = FileService.GetFile();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Files/add")]
        [HttpPost]
        public HttpResponseMessage Add(FileDTO obj)
        {
            var data = FileService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Files/update")]
        [HttpPost]
        public HttpResponseMessage Update(FileDTO obj)
        {
            var data = FileService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Files/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = FileService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
