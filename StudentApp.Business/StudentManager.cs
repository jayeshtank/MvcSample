using StudentApp.DataAccess;
using StudentApp.Interface;
using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Business
{
    public class StudentManager
    {
        private IStudentRepository _studentSqlRepository;

        public StudentManager()
        {
            _studentSqlRepository = new StudentSqlRepository();
        }
        
        public List<StudentViewModel> GetAllStudent()
        {
            return _studentSqlRepository.GetAll();
        }

        public bool InsertStudent(StudentViewModel student)
        {
            return _studentSqlRepository.Insert(student);
        }
    }
}
