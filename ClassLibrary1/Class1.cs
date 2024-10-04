using System;

namespace TriangleCalc
{
    public class Triangle
    {
        public static double Calculate(double A, double B, double C)
        {
            if (A <= 0 || B <= 0 || C <= 0) // проверка на корректность введёных данных
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными.");
            }
            if (A + B <= C || A + C <= B || B + C <= A) // проверка на то, что это треугольник
            {
                throw new ArgumentException("Заданные стороны не могут образовать треугольник.");
            }
            double semiperimeter = (A + B + C) / 2; // полупериметр для формулы Герона
            double area = Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
            return area;
        }
    }
}
