using System;
using System.ComponentModel.DataAnnotations;

namespace StudentApp.Model
{

    public class StudentViewModel
    {
        [Display(Name = "Student ID")]
        [Required(ErrorMessage = "Please enter Student Id")]
        public int? StudentId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter First Name")]
        [MinLength(3, ErrorMessage = "First Name Should be minimum 3 chars.")]
        [MaxLength(10,ErrorMessage ="First Name Should not exceed limit 10 chars.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter Last Name")]
        [MinLength(3, ErrorMessage = "Last Name Should be minimum 3 chars.")]
        [MaxLength(10, ErrorMessage = "Last Name Should not exceed limit 10 chars.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string LastName { get; set; }

        [Range(20,40,ErrorMessage = "Age should be between 20 to 40.")]
        [Display(Name = "Age")]
        [Required(ErrorMessage = "Please enter Student Age")]
        public int Age { get; set; }

        public int Total { get; set; }

        [Display(Name = "Student Email")]
        [EmailAddress(ErrorMessage ="Email Address is invalid.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Student Phone")]
        [Phone(ErrorMessage = "Phone number is invalid.")]
        public string Phone { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public int Gender { get; set; }

        [Display(Name = "Department")]
        [Required]
        public int DepartmentId { get; set; }

        public int CategoryId { get; set; }

        [Display(Name = "Is Student Active")]
        public bool IsActive { get; set; }
    }

    public class StudentDetails : StudentViewModel
    {
        public string DepartmentName { get; set; }

        public string CategoryName { get; set; }

    }
}