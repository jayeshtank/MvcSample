using StudentApp.Interface;
using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.DataAccess
{
    public class StudentSqlRepository : IStudentRepository
    {
        public List<StudentViewModel> GetAll()
        {
            return null;
        }

        public StudentViewModel GetById(int studentId)
        {
            return null;
        }

        public bool Insert(StudentViewModel student)
        {
            return false;
        }
    }
}
