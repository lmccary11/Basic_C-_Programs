using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }
        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Models.Instructor dayTimeInstructor = new Models.Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };
            return View(dayTimeInstructor);
        }
        public ActionResult Instructors()
        {
            List<Models.Instructor> instructors = new List<Models.Instructor>
            {
                new Models.Instructor
                {
                    Id = 1,
                    FirstName = "Rick",
                    LastName = "Ramen"
                },
                new Models.Instructor
                {
                    Id = 2,
                    FirstName = "Brett",
                    LastName = "Calender"
                },
                new Models.Instructor
                {
                    Id = 3,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
                }
            };
            return View(instructors);
        }
    }
}