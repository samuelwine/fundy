using Microsoft.AspNetCore.Mvc;

namespace Fundy.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return RedirectToAction("Index", "Donors");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
