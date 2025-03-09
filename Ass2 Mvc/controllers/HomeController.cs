using Microsoft.AspNetCore.Mvc;

namespace Ass2_Mvc.controllers
{
    public class HomeController : Controller
    {
        // main Actions : Index=>GetAllData ||GetById =>Get specific object|| create || update|| delete
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult AboutUs()
		{
			return View();
		}

	}
}
