/*
* FILE : UnitTest1.cs
* PROGRAMMER : Matt Warren
* FIRST VERSION : 2015-12-07
* DESCRIPTION :
* The functions in this file are used to test the functions in the Triangle class
*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace TriangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_SideConstructor()
        {
            Triangle.Triangle tri = new Triangle.Triangle(15, 20);
            Assert.AreEqual(tri.sideB, 20);
        }

        [TestMethod]
        public void Test_AngleConstructor()
        {
            Triangle.Triangle tri = new Triangle.Triangle(15, 20, 0);
            Assert.AreEqual(tri.angleA, 15);
        }


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
