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
                FirstName = "Jayesh",
                LastName = "Tank"
            });

            stuentsList.Add(new Student
            {
                FirstName = "Rahul",
                LastName = "Dhokia"
            });


            stuentsList.Add(new Student
            {
                FirstName = "Rahul",
                LastName = "Patel"
            });

            stuentsList.Add(new Student
            {
                FirstName = "Rohan",
                LastName = "Patel"
            });

            stuentsList.Add(new Student
            {
                FirstName = "Parth",
                LastName = "Mehta"
            });

            stuentsList.Add(new Student
            {
                FirstName = "Rohan",
                LastName = "Trivedi"
            });
        }

    }
}