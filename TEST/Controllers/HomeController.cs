using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace TEST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TEST2()
        {


            return View();
        }

        public ActionResult TEST3()
        {
            return View();
        }
        public ActionResult TEST4()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpPost]
        public ActionResult TEST3(FormCollection post)
        {
            /*SELECT A.FirstName,A.LastName,B.City,B.State FROM Persion A,Address B WHERE A.PersionId=B.PersionId*/

            return View();
        }
        [HttpPost]
        public ActionResult TEST2(FormCollection post)
        {
            string name = post["name"];
            int sum = 0;
            for (int i = 0; i < name.Length; i++) 
            {
                switch (name[i].ToString()) 
                {
                    case "I":
                        sum += 1;
                        break;
                    case "V":
                        sum += 5;
                        break;
                    case "X":
                        sum += 10;
                        break;
                    case "L":
                        sum += 50;
                        break;
                    case "C":
                        sum += 100;
                        break;
                    case "D":
                        sum += 500;
                        break;
                    case "M":
                        sum += 1000;
                        break;

                }
            }
            ViewBag.SUM = sum;

            return View();
        }

        public ActionResult TEST4(FormCollection post)
        {
            int[] arr = new int[] { 2, 10, 5, 8, 4, 11 };
            Array.Sort(arr);
            ViewBag.Sort = arr;

            return View();
        }
        public ActionResult TEST5(FormCollection post)
        {
            /*ViewData為一個request 就會消失
              ViewBag 使用動態的型別
              TempData 只會進行一次的導向，第二次的時候就會被清除
            */

            return View();
        }

    }
}