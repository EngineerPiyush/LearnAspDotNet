using Microsoft.AspNetCore.Mvc;

namespace PassingDataThroughController.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //passing data through View Data

            //ViewData["name"] = "Piyush";
            //ViewData["age"] = 26;
            //ViewData["TodaysDate"] = DateTime.Now.ToLongDateString();
            //String[] colleagues = {"Farzeen","Amit","Anand"};
            //ViewData["colleagues"] = colleagues;
            //ViewData["courses"] = new List<string>() { "MCA","BCA","Hardware"};

            //passing data through View Bag

            //ViewBag.name = "Piyush";
            //ViewBag.age = 26;
            //ViewBag.TodaysDate = DateTime.Now.ToLongDateString();
            //String[] colleagues = { "Farzeen", "Amit", "Anand" };
            //ViewBag.colleagues = colleagues;
            //ViewBag.courses = new List<string> { "MCA" , "BCA" , "Hardware"};

            //understanding another way to pass data from controller to view using temp data 

            ViewData["name"] = "Piyush";
            ViewBag.age = 26;
            TempData["tempData"] = "This is temp data";
            TempData["courses"] = new List<string> { "MCA" , "BCA" , "Hardware"};

            //return View();

            //the below statement is necessary to use to access temp data in another view (in this case About)
            //and it will work ony first request on the url next tome temp
            //and it will work ony first request on the url on next request tempata can not be access.
            return RedirectToAction("About");

        }

        public IActionResult About()
        {
            // this will keep the temp data for next request as well
            TempData.Keep("tempData");
            TempData.Keep("courses");
            return View();
        }

        public IActionResult Contact()
        {
            TempData.Keep("courses");
            return View();
        }
    }
}
