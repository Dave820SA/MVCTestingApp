using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            throw new Exception("oops!");
            //ViewBag.Message = string.Format("{0}: : {1} {2}", RouteData.Values["controller"],
            //                                                    RouteData.Values["action"],
            //                                                    RouteData.Values["id"]);

            //var model = new RestaurantReview()
            //{
            //    Name = "Big Daddies",
            //    Rating = 9
            //};


            //return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Location = "Texas is best";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
