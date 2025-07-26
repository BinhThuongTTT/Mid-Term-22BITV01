namespace Mid_Term_22BITV01.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string? PhotoImagePath { get; set; }

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }  // For display only
    }
}
