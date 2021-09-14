using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MainClass
    {
        public static double CircleSquare(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double TriangleSquare(double a, double b, double c)
        {
            if (!IsTriangleExist(a, b, c))
            {
                return -1;
            }
            
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static bool IsTriangleExist(double a, double b, double c)//проверка существует ли треугольник
        {
            if (a >= (b + c) || b >= (a + c) || c >= (a + b))
            {
                return false;
            }
            return true;
        }
        
        public static bool IsTriangleRight(double a, double b, double c)//проверка на прямоугольный треугольник
        {
            if (!IsTriangleExist(a, b, c))
            {
                return false;
            }

            if (a > b)//выстраиваем, чтобы было как у пифагора
            {
                if (a > c)
                {
                    double temp = a;
                    a = c;
                    c = temp;
                }
            }
            else
            {
                if (b > c)
                {
                    double temp = b;
                    b = c;
                    c = temp;
                }
            }

            if ((a * a + b * b) == c * c) 
                return true;

            return false;
        }
    }
}
