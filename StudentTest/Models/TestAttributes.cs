using System.ComponentModel.DataAnnotations;

namespace StudentTest.Models
{
    public class TestAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var strValue = value as string;
            if(strValue!=null && !string.IsNullOrWhiteSpace(strValue) && strValue=="OK")
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Not Valid");
        }
    }
}