using Microsoft.AspNetCore.Mvc;

namespace ASPCOREEMPTY.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
