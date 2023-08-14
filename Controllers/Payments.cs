using Microsoft.AspNetCore.Mvc;

namespace mvctest.Controllers
{
	public class Payments : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
