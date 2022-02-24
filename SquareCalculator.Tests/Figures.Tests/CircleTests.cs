using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Tests.Figures.Tests
{ 
    [TestClass]
    class CircleTests
    {
        [TestMethod]
        public void CircleSquare_Radius2_12Expected()
        {
            double radius = 2;
            double expected = 12.5664;

            Circle circle = new Circle(radius);
            double result = circle.GetSquare();

            Assert.AreEqual(expected, result, 0.0001);
        }
        [TestMethod]
        public void CircleSquare_Radius5_78Expected()
        {
            double radius = 5;
            double expected = 78.5398;

            Circle circle = new Circle(radius);
            double result = circle.GetSquare();

            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestMethod]
        public void CircleSquare_Radius0_0Expected()
        {
            double radius = 0;
            double expected = 0;

            Circle circle = new Circle(radius);
            double result = circle.GetSquare();

            Assert.AreEqual(expected, result);
        }
    }
}
