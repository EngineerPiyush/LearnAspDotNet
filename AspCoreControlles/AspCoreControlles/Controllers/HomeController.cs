using Microsoft.AspNetCore.Mvc;

namespace AspCoreControlles.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Name()
        {
            return "Piyush";
        }

        public int Age(int age)
        {
            return age;
        }
    }
    // In a file we can define multiple controllers but it is not a good practice. We should define one controller in one file.

    public class AboutController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }

        public string Degree()
        {
            return "MCA";
        }
    }
}
