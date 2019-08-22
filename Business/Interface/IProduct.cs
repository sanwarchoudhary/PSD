using PDC.Entity;
using System.Threading.Tasks;

namespace PDC.Business.Interface
{
    /// <summary>
    /// This repository interface contains the operations for Product 
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Method to get Parcel with Department details.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>ParcelDetails Object</returns>
        Task<ParcelDetails> GetParcelDetails(string fileName);
    }
}
