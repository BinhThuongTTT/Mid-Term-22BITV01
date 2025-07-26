using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LAB04.Models
{
    public enum Gender { Male, Female }
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name = "Mã nhân viên")]
        [Remote(action: "CheckEmployeeNo", controller: "CheckEmployeeNo")]
        public string EmployeeNo { get; set; }
        //
        [Display(Name = "Họ tên")]
        [MinLength(3, ErrorMessage = "Tối thiểu 3 kí tự")]
        [StringLength(100)]
        public string FullName { get; set; }
        //
        [EmailAddress]
        public string Email { get; set; }
        //
        [EmailAddress]
        [Compare("Email", ErrorMessage = "Email không khớp")]
        public string ComfirmEmail { get; set; }
        //
        [Url]
        public string Website { get; set; }
        //
        [DataType(DataType.Date)]
        [BirthDateCheck]
        [Display(Name = "Ngày sinh")]
        public DateTime BirthDate { get; set; }
        //
        [Display(Name = "Nam")]
        public bool Gender { get; set; } = true;
        //
        [Display(Name = "Lương")]
        [Range(0, double.MaxValue)]
        public double Salary { get; set; }
        //
        [Display(Name = "Bán thời gian")]
        public bool IsPartTime { get; set; }
        //
        [Display(Name = "Địa chỉ")]
        [RegularExpression("[a-zA-Z 0-9]*")]
        public string Address { get; set; }
        //
        [Display(Name = "Điện thoại")]
        [RegularExpression("0[3789][0-9]{8}")]
        public string Phone { get; set; }
        //
        [Display(Name = "Số tài khoản")]
        [DataType(DataType.CreditCard)]
        public string CreditCard { get; set; }
        //
        [Display(Name = "Thông tin thêm")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "Tối đa 500 kí tự")]
        public string Description { get; set; }
        //
    }
    
}
