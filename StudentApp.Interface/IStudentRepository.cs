using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Interface
{
    public interface IStudentRepository
    {

        /// <summary>
        /// This will insert student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        bool Insert(StudentViewModel student);

        List<StudentViewModel> GetAll();

        StudentViewModel GetById(int studentId);
    }
}
