using Microsoft.AspNetCore.Mvc;

namespace PestiOne.Web.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
