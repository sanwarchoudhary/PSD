using PDC.Business.Interface;
using PDC.Entity;
using System;

namespace PDC.Business.Class
{
    public class RegularDepartment : IDepartmentsAssignment
    {
        public string AssignDepartment()
        {
            return Convert.ToString(Departments.Regular);
        }

    }
}
