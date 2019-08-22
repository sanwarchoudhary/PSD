using Business.Class;
using PDC.Business.Interface;
using PDC.Common;
using PDC.Entity;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PDC.Business.Class
{
    /// <summary>
    /// Product manager class to implement interface methods.
    /// </summary>
    public class Product : IProduct
    {
        private IDepartmentsAssignment _departmentsAssignment;

        /// <summary>
        /// Retrieving xml directory.
        /// </summary>

         
        private readonly string xmlDirectory = System.Configuration.ConfigurationManager.AppSettings["XmlDirectory"];

        /// <summary>
        /// Method for getting the department details from xml.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>ParcelDetails Object</returns>
        public Task<ParcelDetails> GetParcelDetails(string fileName)
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory + xmlDirectory + fileName;
            string xmlInputData = string.Empty;
            xmlInputData = File.ReadAllText(path);
            var result = AssignDepartments(Serializer.Instance.Deserialize<ParcelDetails>(xmlInputData));
            return Task.FromResult(result);
        }

        /// <summary>
        /// Method to assign departments in parcel object.
        /// </summary>
        /// <param name="parcelDetails">ParcelDetails Object</param>
        /// <returns>ParcelDetails Object</returns>
        private ParcelDetails AssignDepartments(ParcelDetails parcelDetails)
        {
            foreach (var parcel in parcelDetails.Parcels.Parcel)
            {
                var parcelWeight = Convert.ToDecimal(parcel.Weight);
               _departmentsAssignment = DepartmentFactory.GetDepartments(parcelWeight);
                parcel.Department = _departmentsAssignment.AssignDepartment();
            }
            return parcelDetails;
        }
    }
}
