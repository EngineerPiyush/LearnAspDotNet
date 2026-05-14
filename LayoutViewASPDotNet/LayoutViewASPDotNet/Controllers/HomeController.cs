using Microsoft.AspNetCore.Mvc;

namespace LayoutViewASPDotNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult WithoutLayout()
        {
            return View();
        }
    }
}
