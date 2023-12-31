﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvctest.Controllers
{
    public class Teacher : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
