using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Infrastructure;
using Autofac;
using WebApi.DependencyTest;

namespace WebApi.Controllers
{
    
    public class HomeController : Controller
    {
        public IDependen service { get; set; }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public HomeController(IDependen service)
        {
            this.service = service;
        }

        public ActionResult AutofacDemo()
        {
            //service = WorkContext.GetServiceObject();
            //string s = service.CreateService("ssss");

            //IDependen iDependen = WorkDependen.container.Resolve<IDependen>();
            //string d = iDependen.InstanceId.ToString();
            string s = service.InstanceId.ToString();
            return View();
        }
    }
}
