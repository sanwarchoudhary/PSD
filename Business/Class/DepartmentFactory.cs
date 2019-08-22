using PDC.Business.Class;
using PDC.Business.Interface;

namespace Business.Class
{
    /// <summary>
    /// Factory class.
    /// </summary>
    public class DepartmentFactory
    {

        public static IDepartmentsAssignment GetDepartments(decimal parcelWeight)
        {
            if (parcelWeight <= 1)
            {
                return new MailDepartment();
            }
            else if (parcelWeight > 1 && parcelWeight <= 10)
            {
                return new RegularDepartment();
            }
            else if (parcelWeight > 10 && parcelWeight <= 1000)
            {
                return new HeavyDepartment();
            }
            return new InsuranceDepartment();
        }
    }
}
