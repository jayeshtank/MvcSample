using StudentApp.DataAccess;
using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Business
{
    public class DashboardManager
    {
        public DashboardCount GetDashboarCount()
        {
            return new DashboardCount
            {
                DepartmentCount = 10,
            };
        }

        public StudentViewModel GetStudenHigestMark()
        {
            return null;
        }
    }
}
