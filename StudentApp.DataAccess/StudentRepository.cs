using StudentApp.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace StudentApp.DataAccess
{
    public static class StudentRepository
    {
        private static List<StudentViewModel> stuentsList=null;
        
        static StudentRepository()
        {
            stuentsList = new List<StudentViewModel>();
            Init();
        }
        
        public static bool Insert(StudentViewModel student)
        {
            try
            {
                //var tmp = new Student();
                //tmp.Student_Id = student.StudentId.Value;
                //tmp.Student_FName = student.FirstName;
                //tmp.Student_FName = student.FirstName;

                //DbContext.Add<Student>(tmp);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<StudentViewModel> GetAll()
        {
            return null;
        }

        public static int GetStudentCount()
        {
            return stuentsList.Count;
        }

        private static void Init()
        {
            stuentsList.Add(new StudentViewModel
            {
                StudentId = 1,
                FirstName = "Jayesh",
                Age = 10,
                LastName = "Tank",
                DepartmentId = 1,
                CategoryId = 1,
            });

            stuentsList.Add(new StudentViewModel
            {
                StudentId = 5,
                FirstName = "Rahul",
                Age = 20,
                LastName = "Dhokia",
                DepartmentId = 1,
                CategoryId = 2,
            });

            stuentsList.Add(new StudentViewModel
            {
                StudentId = 2,
                Age = 30,
                FirstName = "Rahul",
                LastName = "Patel",
                DepartmentId = 1,
                CategoryId = 3,
            });

            stuentsList.Add(new StudentViewModel
            {

                StudentId = 4,
                Age = 40,
                FirstName = "Rohan",
                LastName = "Patel",
                DepartmentId = 2,
                CategoryId = 1,
            });

            stuentsList.Add(new StudentViewModel
            {
                StudentId = 6,
                Age = 50,
                FirstName = "Parth",
                LastName = "Mehta",
                DepartmentId = 2,
                CategoryId = 2,
            });

            stuentsList.Add(new StudentViewModel
            {
                StudentId = 6,
                Age = 30,
                FirstName = "Rohan",
                LastName = "Trivedi",
                DepartmentId = 2,
                CategoryId = 2,
            });
        }
    }
}