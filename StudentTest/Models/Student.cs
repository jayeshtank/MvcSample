using System;
using System.ComponentModel.DataAnnotations;

namespace StudentTest.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public int? StudentId { get; set; }

        [Display(Name = "First Name")]
        //[RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public int Gender { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Display(Name = "Is Student Active")]
        public bool IsActive { get; set; }
    }
}