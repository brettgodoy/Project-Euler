using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectEulerProblem25.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Time to solve this problem! Whoo!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CalculateAnswer() 
        {
            Int64 sum = 0;
            Int64 num1 = 0;
            Int64 num2 = 1;
            List<Int64> numList = new List<Int64>();

            while (num2.ToString().Length <= 1000) {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;

            }

           
            ViewBag.Message = "The answer is " + num2;
            
            //ViewBag.Message = "The answer is";

            return View();
        }
    }
}
