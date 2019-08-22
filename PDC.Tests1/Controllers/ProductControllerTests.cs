using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PDC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDC.Controllers.Tests
{
    [TestClass()]
    public class ProductControllerTests
    {
        public ProductControllerTests()
        {

        }
        [TestMethod()]
        public void GetParcelDetailsTest()
        {
            var obj = new Mock<ProductController>();
            // var parcelDetails = new ParcelDetails();
            obj.Setup(x => x.GetParcelDetails());
            var result = obj.Object.GetParcelDetails();
            Assert.AreNotEqual(4, result);
        }
    }
}