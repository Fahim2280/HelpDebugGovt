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
    public class SubscriptionController : ApiController
    {
        [Route("api/Subscriptions")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = SubscriptionService.GetSubscriptions();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Subscriptions/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = SubscriptionService.GetSubscriptions();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Subscriptions/add")]
        [HttpPost]
        public HttpResponseMessage Add(SubscriptionDTO obj)
        {
            var data = SubscriptionService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Subscriptions/update")]
        [HttpPost]
        public HttpResponseMessage Update(SubscriptionDTO obj)
        {
            var data = SubscriptionService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Subscriptions/delete")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = SubscriptionService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
