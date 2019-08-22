using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PDC.Business.Interface;
using PDC.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace PDC.Web.Controllers.Tests
{
    /// <summary>
    /// productcontroller test class.
    /// </summary>
    [TestClass()]
    public class ProductControllerTests
    {
        /// <summary>
        /// method to get test result using moq.
        /// </summary>
        [TestMethod()]
        public async Task GetParcelDetailsTest()
        {
            var obj = new Mock<ProductController>();
            var parcelDetails = new ParcelDetails();
            var userMock = new Mock<IProduct>();
            userMock.Setup(p => p.GetParcelDetails("Container_68465468.xml")).Returns(Task.FromResult(parcelDetails));
            var productController = new ProductController(userMock.Object);
            var result = await productController.GetParcelDetails();
            Assert.AreEqual(((ViewResult)result).ViewName, "GetparcelDetails");
        }
    }
}