using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagAndViewDataTutorial.Models;

namespace ViewBagAndViewDataTutorial.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyCustomProp = "Vinay";
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Ajay1",Email="A@mail.com"},
                new Employee(){Id=2,Name="Ajay2",Email="B@mail.com"},
                new Employee(){Id=3,Name="Ajay3",Email="C@mail.com"},
                new Employee(){Id=4,Name="Ajay4",Email="D@mail.com"}
            };
            ViewBag.EmployeeList=employees;
            return View();
        }

        public ActionResult Demo()
        {
            ViewData["MyKey"] = "This is value for my key";

            ViewData["MydataList"] = new List<string> { "Arun", "Vamshi", "Kiran", "Giri" };
            return View();
        }
    }
}