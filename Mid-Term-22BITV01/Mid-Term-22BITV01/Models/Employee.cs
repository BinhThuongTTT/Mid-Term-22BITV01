namespace Mid_Term_22BITV01.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhotoImagePath { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
