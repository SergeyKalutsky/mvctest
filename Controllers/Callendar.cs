using Microsoft.AspNetCore.Mvc;

namespace mvctest.Controllers
{
	public class Callendar : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
