using SquareCalculator.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Figures
{
    public class Circle : IFigure
    {
        double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
