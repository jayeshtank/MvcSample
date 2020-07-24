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
                stuentsList.Add(student);
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

    }
}