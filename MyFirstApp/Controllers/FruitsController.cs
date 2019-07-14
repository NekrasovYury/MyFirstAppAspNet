using MyFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class FruitsController : Controller
    {
        // GET: Fruits
        public ActionResult Index(int? id)
        {
            
            List<Fruits> fruct = new List<Fruits>();
            fruct.Add(new Fruits()
            {
                Category = "qweqwe",
                Name = "asdasd",
                FruitsId = 1,
                Price = 21m


            });
            fruct.Add(new Fruits()
            {
                Category = "232",
                Name = "44444",
                FruitsId = 2,
                Price = 321m


            });
            fruct.Add(new Fruits()
            {
                Category = "asdfff",
                Name = "aswwwwwdasd",
                FruitsId = 3,
                Price = 231m


            });



            return View(id != null ? fruct.Where(_ => _.FruitsId == id.Value).ToList() : fruct);
        }
    }
}