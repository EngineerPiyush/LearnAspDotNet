using DOTNETCOREMVC.Models;
using Microsoft.AspNetCore.Mvc;
using ModelInDotNetCore.Models;
using System.Diagnostics;

namespace DOTNETCOREMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<StudentModel>
            {
                new StudentModel{ rollNo = 1, age = 23, name ="Rajat", city="gaziabad" },
                new StudentModel{ rollNo = 2, age = 24, name ="Rahul", city="bulandshar"},
                new StudentModel{ rollNo =3, age = 26, name="Abhay", city="Noida"}
            };
            ViewData["myStudents"] = students;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
