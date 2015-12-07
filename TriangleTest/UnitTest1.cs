using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace TriangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AreaCalculation()
        {
            Triangle.Triangle tri = new Triangle.Triangle(20, 20);
            double status = tri.CalculateArea();
            Assert.AreEqual(200, status);
        }
    }
}
