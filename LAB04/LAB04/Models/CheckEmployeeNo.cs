using Microsoft.AspNetCore.Mvc;


namespace LAB04.Models
{
    public class EmployeeNo : Controller
    {
        public IActionResult CheckEmployeeNo(string EmployeeNo)
        {
            if(EmployeeNo == "777")
            {
                return Json(data: "Mã này đã có");
            }
            else
                {
                return Json(data: true);
            }
        }
    }
}
