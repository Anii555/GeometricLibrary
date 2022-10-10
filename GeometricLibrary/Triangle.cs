using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Triangle : Shape
    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public double Side3 { get; set; }

        public Triangle (string typeName, double side1, double side2, double side3) : base (typeName)
        {
            if (isExist(side1, side2, side3))
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double Square()
        {
            var p = (Side1 + Side2 + Side3) / 2;
            var square = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            return square;
        }

        public bool isExist(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                throw new ArgumentException("Сторона(ы) треугольника не могут быть меньше 0. Введите другие значения для расчётов.");
            }

            if (side1 > (side2 + side3) || side2 > (side1 + side3) || side3 > (side1 + side2))
            {
                throw new ArgumentException("Сторона треугольника не может быть больше суммы двух других. Введите другие значения для расчётов.");
            }

            return true;
        }

        /// Проверка на то, является ли треугольник прямоугольным
        public bool isStraightTriangle()
        {
            bool isStraight = (Side1 == Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side2, 2))
                    || Side2 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2))
                    || Side3 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2)));

            return isStraight;
        }
    }
}
