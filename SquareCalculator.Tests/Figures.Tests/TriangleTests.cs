using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareCalculator.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleSquare_3And4And5_6Expected()
        {
            double a = 3, b = 4, c = 5;
            double expected = 6;

            Triangle triangle = new Triangle(a, b, c);
            double result = triangle.GetSquare();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TriangleSquare_2And4And4_3Expected()
        {
            double a = 2, b = 4, c = 4;
            double expected = 3.873;

            Triangle triangle = new Triangle(a, b, c);
            double result = triangle.GetSquare();

            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void IsTriangleRight_3And4And5_TrueExpected()
        {
            double a = 3, b = 4, c = 5;
            bool expected = true;

            Triangle triangle = new Triangle(a, b, c);
            bool result = triangle.IsRight;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsTriangleRight_2And2And3_FalseExpected()
        {
            double a = 2, b = 2, c = 3;
            bool expected = false;

            Triangle triangle = new Triangle(a, b, c);
            bool result = triangle.IsRight;

            Assert.AreEqual(expected, result);
        }
    }
}
