using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Domain;

namespace HelloWorld.Common
{
    public class BaseController : Controller
    {
        // GET: Base
        protected ServiceManager _srvMngr = new ServiceManager();
        protected ModelManager _modelMngr = new ModelManager();

        public ServiceManager ServiceManager
        {
            get { return _srvMngr; }
        }

        public ModelManager ModelManager
        {
            get { return _modelMngr; }
        }
    }
}