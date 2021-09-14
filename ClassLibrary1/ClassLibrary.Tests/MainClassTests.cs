using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace ClassLibrary.Tests
{
    [TestClass]
    public class MainClassTests
    {
        [TestMethod]
        public void CircleSquare_Radius2_12Expected()
        {
            double radius = 2;
            double expected = 12.5664;

            double result = MainClass.CircleSquare(radius);

            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestMethod]
        public void CircleSquare_Radius5_78Expected()
        {
            double radius = 5;
            double expected = 78.5398;

            double result = MainClass.CircleSquare(radius);

            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestMethod]
        public void CircleSquare_Radius0_0Expected()
        {
            double radius = 0;
            double expected = 0;

            double result = MainClass.CircleSquare(radius);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TriangleSquare_3And4And5_6Expected()
        {
            double a = 3, b = 4, c = 5;
            double expected = 6;

            double result = MainClass.TriangleSquare(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TriangleSquare_2And4And4_3Expected()
        {
            double a = 2, b = 4, c = 4;
            double expected = 3.873;

            double result = MainClass.TriangleSquare(a, b, c);

            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void IsTriangleRight_3And4And5_TrueExpected()
        {
            double a = 3, b = 4, c = 5;
            bool expected = true;

            bool result = MainClass.IsTriangleRight(a, b, c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsTriangleRight_2And2And3_FalseExpected()
        {
            double a = 2, b = 2, c = 3;
            bool expected = false;

            bool result = MainClass.IsTriangleRight(a, b, c);

            Assert.AreEqual(expected, result);
        }
    }
}
