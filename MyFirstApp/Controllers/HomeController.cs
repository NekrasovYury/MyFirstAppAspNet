using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    //public class JsonResult
    //{
    //    public string Test { get; set; }
    //    public int ID { get; set; }
    //}
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Variable = RouteData.Values["id"];
            return View();
        }

       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SecretButton(int? id)
        {
            ViewBag.Variable = id;

            ViewBag.Message = "Your application description page.";

            return View();
        }
        public JsonResult Get(int? id)
        {
            return Json( new { Test = "123", Id = id }, JsonRequestBehavior.AllowGet);
        }

        
       
    }
}