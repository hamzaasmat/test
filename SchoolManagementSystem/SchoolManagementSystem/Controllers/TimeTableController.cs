using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class TimeTableController : Controller
    {
        // GET: TimeTable
        public ActionResult Time_Table()
        {
            return View();
        }

        // GET: Time Table Report
        public ActionResult Time_Table_Report()
        {
            return View();
        }
    }
}