using StudentTest.Models;
using System.Collections.Generic;

namespace StudentTest.Repository
{
    public static class StudentRepository
    {
        private static List<Student> stuentsList=null;
        
        static StudentRepository()
        {
            stuentsList = new List<Student>();
            Init();
        }
        
        public static bool Insert(Student student)
        {
            try
            {
                var tmp = new TblStudents();
                tmp.Id = student.StudentId;
                tmp.FName = student.FirstName;

               // _Context.Add(tmp);
               
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Student> GetAll()
        {
            return stuentsList;
        }

        public static int GetStudentCount()
        {
            return stuentsList.Count;
        }


        private static void Init()
        {
            stuentsList.Add(new Student
            {
                StudentId = 1,
                FirstName = "Jayesh",
                Age = 10,
                LastName = "Tank",
                DepartmentId = 1,
                CategoryId = 1,
            });

            stuentsList.Add(new Student
            {
                StudentId = 5,
                FirstName = "Rahul",
                Age = 20,
                LastName = "Dhokia",
                DepartmentId = 1,
                CategoryId = 2,
            });

            stuentsList.Add(new Student
            {
                StudentId = 2,
                Age = 30,
                FirstName = "Rahul",
                LastName = "Patel",
                DepartmentId = 1,
                CategoryId = 3,
            });

            stuentsList.Add(new Student
            {

                StudentId = 4,
                Age = 40,
                FirstName = "Rohan",
                LastName = "Patel",
                DepartmentId = 2,
                CategoryId = 1,
            });

            stuentsList.Add(new Student
            {
                StudentId = 6,
                Age = 50,
                FirstName = "Parth",
                LastName = "Mehta",
                DepartmentId = 2,
                CategoryId = 2,
            });

            stuentsList.Add(new Student
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