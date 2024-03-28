using Abdul22.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Abdul22.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Employee emp = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName="Abdul",
            //    Designation = "Manager",
            //    Salary = 25000,
            //};

            /////////////////////////////////////////////////////////////////

            var myEmployees = new List<Employee>
            {
                new Employee {EmpId=101,EmpName="Prem",Designation="Manager",Salary=20000},
                new Employee {EmpId=102,EmpName="Preet",Designation="Manager",Salary=30000},
                new Employee {EmpId=103,EmpName="Punam",Designation="Manager",Salary=40000},
                new Employee {EmpId=104,EmpName="Pavan",Designation="Manager",Salary=50000},
                new Employee {EmpId=105,EmpName="Pasvan",Designation="Manager",Salary=60000},
            };


            //ViewData["myEmploye"] = emp; //to abhi yha hum ne viewdata ke 
            //through data pass kiya hai is ko hum viewbag ke through bhi 
            //kar sakte hai 

            //ViewBag.myEmploye = emp;

            //TempData["myEmploye"] = emp;



            //ViewData["myEmployee"]=myEmployees;  //Jis tarah yha hum viewdata ke 
            //through data ko pass kar rahe hai similerly viewbag and viewtemp ke 
            //through bhi hum isis tarah data ko pass kar sakte hai 

            //ViewBag.myEmployee = myEmployees;

            TempData["myEmployee"] = myEmployees;
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
