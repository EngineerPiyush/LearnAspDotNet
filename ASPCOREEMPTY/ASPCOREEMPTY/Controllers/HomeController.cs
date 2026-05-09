using Microsoft.AspNetCore.Mvc;

namespace ASPCOREEMPTY.Controllers
{
    //    public class HomeController : Controller
    //    {
    //        [Route("/hoome/index")]
    //        [Route("")]
    //        [Route("/home")]
    //        public IActionResult Data()
    //        {
    //            return View("~/Views/Home/Index.cshtml");
    //        }
    //        [Route("home/about")]
    //        [Route("/about")]
    //        public IActionResult About()
    //        {
    //            return View();
    //        }

    //        [Route("home/details/{id?}")]
    //        public int Details(int ? id)
    //        {
    //            return id ?? 1;
    //        }
    //    }
    //}

    [Route("home")]
    public class HomeController : Controller
{
    //[Route("")] will not work 
    [Route("/index")]
    [Route("~/")]
        public IActionResult Data()
    {
        return View("~/Views/Home/Index.cshtml");
    }
    [Route("home/about")]
    [Route("/about")]
    public IActionResult About()
    {
        return View();
    }

    [Route("home/details/{id?}")]
    public int Details(int? id)
    {
        return id ?? 1;
    }
}
}
