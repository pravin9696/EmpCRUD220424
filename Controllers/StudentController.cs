using EmpCRUD220424.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpCRUD220424.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
         //CRUD
         //C-create
         //r- read
         //u-update
         //d-Detele

      public ActionResult insertStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insertStudent(tblStudent st)
        {
            MyEntity medb= new MyEntity();
            medb.tblStudents.Add(st);
            int n=medb.SaveChanges();
            if (n > 0)
            {
                return RedirectToAction("showAll");
            }
            else
            {
                return View();
            }
        }
        public ActionResult showAll()
        {
            MyEntity meobj = new MyEntity();
            List<tblStudent> studlist = meobj.tblStudents.ToList();


            return View(studlist);
        }

    }
}