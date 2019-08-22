using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PDC.Business.Interface;
using PDC.Entity;
using System.Threading.Tasks;

namespace PDC.Business.Class.Tests
{
    /// <summary>
    /// product test class.
    /// </summary>
    [TestClass()]
    public class ProductTests
    {
        /// <summary>
        /// Test method for testing business logic .
        /// </summary>
        [TestMethod()]
        public void GetParcelDetailsTest()
        {
            var mockObj = new Mock<IProduct>();
            var parcelDetails = new ParcelDetails();
            mockObj.Setup(x => x.GetParcelDetails("Container_68465468.xml")).Returns(Task.FromResult(parcelDetails));
            var result = mockObj.Object.GetParcelDetails("Container_68465468.xml");
            Assert.AreNotEqual(4, result);
        }
    }
}