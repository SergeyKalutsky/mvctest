using Microsoft.AspNetCore.Mvc;

namespace mvctest.Controllers
{
	public class Group : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Lessons()
		{
			return View();
		}

		public IActionResult History()
		{
			return View();
		}

		public IActionResult Notes()
		{
			return View();
		}

	}
}
