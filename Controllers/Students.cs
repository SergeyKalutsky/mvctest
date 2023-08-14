using Microsoft.AspNetCore.Mvc;

namespace mvctest.Controllers
{
	public class Students : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
