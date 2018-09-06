using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher Information
        public ActionResult Teacher_Information()
        {
            return View();
        }
        // GET: Teacher Report
        public ActionResult Teacher_Report()
        {
            return View();
        }

        // GET: Teacher Attendance
        public ActionResult Teacher_Attendance()
        {
            return View();
        }

        // GET: Teacher Attendance Report
        public ActionResult Teacher_Attendance_Report()
        {
            return View();
        }
        // GET: Teacher Promotion
        public ActionResult Teacher_Promotion()
        {
            return View();
        }
        // GET: Teacher Promotion Report
        public ActionResult Teacher_Promotion_Report()
        {
            return View();
        }
        
    }
}