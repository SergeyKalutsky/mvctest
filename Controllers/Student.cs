﻿using Microsoft.AspNetCore.Mvc;

namespace mvctest.Controllers
{
	public class Student : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
