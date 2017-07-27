using HelloWorld.Common;
using HelloWorld.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace HelloWorld.Controllers
{
    public class MessageAPIController : BaseApiController

    {
        // GET: MessageAPI
        public string Get()
        {
            IMessage messageModel = (ServiceManager.MessageService.GetMessage());
            var json = new JavaScriptSerializer().Serialize(messageModel);
            return json;
        }

        // POST: MessageAPI
        /// <summary>
        /// Future enhancement for saving message to db
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
            throw new HttpResponseException(HttpStatusCode.NotImplemented);
        }

        // PUT: MessageAPI/5
        /// <summary>
        /// Future enhancement for updating message in db
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
            throw new HttpResponseException(HttpStatusCode.NotImplemented);
        }

        // DELETE: MessageAPI/5
        /// <summary>
        /// Future enhancement for removing an message from db
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            throw new HttpResponseException(HttpStatusCode.NotImplemented);
        }
    }
}
