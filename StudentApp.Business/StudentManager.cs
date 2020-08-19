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
        private readonly IStudentRepository _studentSqlRepository;

        #region Private Methods
     
        #endregion

        #region Public Methods
        public StudentManager()
        {
            _studentSqlRepository = new StudentSqlRepository();
        }
        
        /// <summary>
        /// This method will return all of the student list
        /// </summary>
        /// <returns>List of students</returns>
        public List<StudentViewModel> GetAllStudent()
        {
            return _studentSqlRepository.GetAll();
        }

        public bool InsertStudent(StudentViewModel student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student");
            }

            return _studentSqlRepository.Insert(student);
        }

        /// <summary>
        /// This method will return addition
        /// </summary>
        /// <param name="num1">input value 1</param>
        /// <param name="num2">input value 2</param>
        /// <returns>addition result</returns>
        public int Sum(int num1,int num2)
        {
            #region Sum
            var result = num1 + num2;
            var today = DateTime.Now;
            return result;
            #endregion
        }

        public int Sub(int num1, int num2)
        {
            var result = num1 + num2;
            var today = DateTime.Now;
            return result;
        }
        #endregion
    }

    public enum Verification
    {
        Phone=100,
        Email=101,
    }
}
