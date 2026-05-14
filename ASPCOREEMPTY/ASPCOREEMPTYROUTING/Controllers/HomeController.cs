using Microsoft.AspNetCore.Mvc;

namespace ASPCOREEMPTY.Controllers
{
    //    public class JustController : Controller
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

    //    [Route("home")]
    //    public class HomeController : Controller
    //{
    //    //[Route("")] will not work 
    //    [Route("index")]
    //    [Route("~/")]
    //        public IActionResult Data()
    //    {
    //        return View("~/Views/Home/Index.cshtml");
    //    }

    //    [Route("details/{id?}")]
    //    public int Details(int? id)
    //    {
    //        return id ?? 1;
    //    }
    //[Route("[controller]")]
    //public class HomeController : Controller
    //{
    //    //[Route("")] will not work 
    //    [Route("[action]")]
    //    [Route("~/")]
    //    public IActionResult Index()
    //    {
    //        return View("~/Views/Home/Index.cshtml");
    //    }

    //    [Route("[action]/{id?}")]
    //    public int Details(int? id)
    //    {
    //        return id ?? 1;
    //    }

    //[Route("[controller]/[action]")]
    //public class HomeController : Controller
    //{
    //    [Route("")] 
    //    [Route("~/")]
    //    public IActionResult Index()
    //    {
    //        return View("~/Views/Home/Index.cshtml");
    //    }

    //    [Route("{id?}")]
    //    public int Details(int? id)
    //    {
    //        return id ?? 1;
    //    }

    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult About()
        {
            return View();
        }

        [Route("{id?}")]
        public int Details(int? id)
        {
            return id ?? 1;
        }
    }
}
