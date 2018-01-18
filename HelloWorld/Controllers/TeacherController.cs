using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            Teacher newTeacher = new Teacher { TeacherName = "Sang", Age = 24, Gender = "male", TeacherId = 1311 };
            return View(newTeacher);
        }
    }
}