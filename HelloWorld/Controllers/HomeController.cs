using HelloWorld.Domain.Models;
using HelloWorld.Models;
using HelloWorld.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Domain;
using System.Configuration;

namespace HelloWorld.Controllers
{
    public class HomeController : Common.BaseController
    {

        /// <summary>
        /// Default View - Allows the display of the Hello World message on the screen
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            IMessage messageModel = (ServiceManager.MessageService.GetMessage());

            Boolean WriteToConsole = false;
            Boolean WriteToScreen = false;

            Boolean.TryParse(ConfigurationManager.AppSettings["WriteToConsole"], out WriteToConsole);
            Boolean.TryParse(ConfigurationManager.AppSettings["WriteToScreen"], out WriteToScreen);

            if (WriteToConsole) System.Diagnostics.Debug.WriteLine(messageModel.Value);

            model.Message = messageModel != null ? (WriteToScreen == true ? messageModel.Value : "") : "Domain Object Failed To Load";
            
            return View(model);
        }
    }
}