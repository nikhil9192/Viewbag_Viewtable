using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viewbag_Viewtable.Models;


namespace Viewbag_Viewtable.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Name = "Nikhil Singh";
            ViewBag.List=new List<string>() { "Nikhil singh","Suresh raina","Mohd Yusaf"};
            List<Employee> list = new List<Employee>()
            {
                new Employee(){Empid=121,Empname= "Nikhil Singh",Empage=23},
                new Employee(){Empid=122,Empname= "Ganesh Singh",Empage=23},
                 new Employee(){Empid=123,Empname= "Swantrt tripathi",Empage=25},
                new Employee(){Empid=124,Empname= "Mukesh Chabra",Empage=23}
            };
            ViewBag.obj=list;
            return View();
        }

        public ActionResult Index2()
        {
            ViewData["MyKey"] = "This is value of my key";
            ViewData["Mylist"]=new List<string>() { "Gopal","Shreya","Ritu"};

            return View();
        }
    }

}