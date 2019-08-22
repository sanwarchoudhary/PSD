using PDC.Business.Interface;
using PDC.Entity;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PDC.Web.Controllers
{
    /// <summary>
    /// product controller.
    /// </summary>
    public class ProductController : Controller
    {

        private readonly IProduct _product;

        /// <summary>
        /// contains the name of xml file.
        /// </summary>
        private const string fileName = "Container_68465468.xml";

        /// <summary>
        /// constructor to inject dependencies. 
        /// </summary>
        /// <param name="product"></param>
        public ProductController(IProduct product)
        {
            _product = product;
        }

       
        /// <summary>
        /// Method to get parcel with department details.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> GetParcelDetails()
        {
            var model = new ParcelDetails();
            model = await _product.GetParcelDetails(fileName);
            return View("GetparcelDetails", model);
        }
    }
}