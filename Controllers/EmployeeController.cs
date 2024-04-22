using EmpCRUD220424.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpCRUD220424.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult signup() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(employee emp)
        {
            return View("showDetails",emp);
        }
    }
}