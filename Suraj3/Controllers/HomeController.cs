using Suraj3.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suraj3.Controllers
{
    public class HomeController : Controller
    {
        EmployeeEntities Db1 = new EmployeeEntities();
        public ActionResult Index()
        {
            var data = Db1.Students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student e)
        {
            Db1.Students.Add(e);
            Db1.SaveChanges();
            return RedirectToAction("Index");
            return View(e);
        }
    }
    
}