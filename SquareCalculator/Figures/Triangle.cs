using SquareCalculator.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareCalculator
{
    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool IsRight { get => IsTriangleRight(); }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (IsTriangleExists(sideA, sideB, sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
            {
                throw new Exception("Треугольника с такими сторонами не существует");
            }
        }

        public double GetSquare()
        {
            double perimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
        }
        
        private bool IsTriangleExists(double sideA, double sideB, double sideC)
        {
            return !(sideA >= (sideB + sideC) || 
                     sideB >= (sideA + sideC) || 
                     sideC >= (sideA + sideB));
        }

        private bool IsTriangleRight()
        {
            double[] sides = new double[] { SideA, SideB, SideC };
            double hypothenuse = sides.Max();
            
            List<double> cathets = new List<double>();
            foreach (double side in sides)
            {
                if (side != hypothenuse) cathets.Add(side);
            }

            double cathetsSquares = 0;
            foreach(double cathet in cathets)
            {
                cathetsSquares += cathet * cathet;
            }

            return cathetsSquares == hypothenuse * hypothenuse;
        }
    }
}
