using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LAB04.Models
{
    public class BirthDateCheckAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
        ValidationContext validationContext)
        {
            var model = validationContext.ObjectInstance as Employee;
            if (model == null)
            {
                throw new ArgumentException("Tham số truyền không đúng");
            }
            if (DateTime.Now.Year - model.BirthDate.Year < 10)
            {
                return new ValidationResult("Chưa đủ 10 tuổi");
            }
            return ValidationResult.Success;
        }
    }
}
