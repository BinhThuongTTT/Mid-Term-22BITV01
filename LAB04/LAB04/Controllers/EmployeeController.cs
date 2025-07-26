using LAB04.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB04.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            return View();
        }

    }

}
