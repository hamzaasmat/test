﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        // GET: Signup
        public ActionResult Signup()
        {
            return View();
        }
    }
}