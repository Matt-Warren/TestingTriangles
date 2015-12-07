using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace TriangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_MissingAngle()
        {
            Triangle.Triangle tri = new Triangle.Triangle();
            tri.angleA = 50;
            tri.angleC = 2;
            double status = tri.GetMissingAngle('b');
            Assert.AreEqual(Math.Round(status, 4), status);
        }


        [TestMethod]
        public void Test_Cosine()
        {
            Triangle.Triangle tri = new Triangle.Triangle(20, 10);
            tri.angleC = 56;
            double status = tri.Cosine('c');
            Assert.AreEqual(Math.Round(16.62296, 4), status);
        }


        [TestMethod]
        public void Test_AreaCalculation()
        {
            Triangle.Triangle tri = new Triangle.Triangle(20, 20);
            double status = tri.CalculateArea();
            Assert.AreEqual(200, status);
        }

        [TestMethod]
        public void Test_Pythagorean()
        {
            Triangle.Triangle tri = new Triangle.Triangle(20, 20);
            double status = tri.GetSideC();
            Assert.AreEqual(Math.Round(28.2842712475,4), status);
        }
    }
}
