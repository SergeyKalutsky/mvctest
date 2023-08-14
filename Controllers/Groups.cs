using Microsoft.AspNetCore.Mvc;

namespace mvctest.Controllers
{
	public class Groups : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
