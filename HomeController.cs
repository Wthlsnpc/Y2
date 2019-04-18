using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using news2.Models;
using System.IO;

namespace news2.Controllers
{
    
    public class HomeController : Controller
    {
        NewsContext db = new NewsContext();

        public ActionResult Index()
        {
            return View(db.AllNews);
        }

        [Authorize]
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        [HttpPost]
        public ActionResult About(News n)
        {
           
                db.AllNews.Add(n);
                db.SaveChanges();

                return RedirectToAction("Index");
            
        }
    }
}
