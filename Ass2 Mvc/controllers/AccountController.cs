using Microsoft.AspNetCore.Mvc;

namespace Ass2_Mvc.controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
