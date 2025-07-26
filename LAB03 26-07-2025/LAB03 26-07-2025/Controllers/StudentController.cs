using LAB03_26_07_2025.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LAB03_26_07_2025.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Manage(Student model, String command)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot", "Student.txt");
            if (command == "Lưu TXT")
            {
                String[] lines = { model.Id, model.Name, model.Marks.ToString() };
                System.IO.File.WriteAllLines(path, lines);
                ViewBag.Message = "Đã ghi vào file !";
            }
            else if (command == "Mở")
            {
                String[] lines = System.IO.File.ReadAllLines(path);
                ViewBag.Id = lines[0];
                ViewBag.Name = lines[1];
                ViewBag.Mark = Convert.ToDouble(lines[2]);
                ViewBag.Message = "Đã đọc từ file !";
            }
            return View("Index", model);
        }
    }
}


