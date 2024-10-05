using System;

namespace Calc
{
    public class Triangle
    {
        public static double Calculate(double A, double B, double C)
        {
            if (A <= 0 || B <= 0 || C <= 0) 
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными.");
            }
            if (A + B <= C || A + C <= B || B + C <= A) 
            {
                throw new ArgumentException("Заданные стороны не могут образовать треугольник.");
            }
            double semiperimeter = (A + B + C) / 2; 
            double area = Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
            return area;
        }
    }
    public class Circle
    {
        public static double Calculate(double radius)
        {
            if(radius<= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля");
            }
            double area = double.Pi * radius * radius;
            return area;
        }
    }
}
