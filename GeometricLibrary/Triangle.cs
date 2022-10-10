using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Triangle : Shape
    {
        /// <summary>
        /// Сторона треугольника - A
        /// </summary>
        public double Side1 { get; set; }

        /// <summary>
        /// Сторона треугольника - B
        /// </summary>
        public double Side2 { get; set; }

        /// <summary>
        /// Сторона треугольника - C
        /// </summary>
        public double Side3 { get; set; }

        public Triangle(string typeName, double side1, double side2, double side3) : base(typeName)
        {
            // Проверка треугольника на соответствие
            // базовым требованиям геометрии.
            if (side1 <= 0
                || side2 <= 0
                || side3 <= 0)
            {
                throw new ArgumentException("Сторона(ы) треугольника не могут быть меньше 0. Введите другие значения для расчётов.");
            }

            if (side1 > (side2 + side3)
                || side2 > (side1 + side3)
                || side3 > (side1 + side2))
            {
                throw new ArgumentException("Сторона треугольника не может быть больше суммы двух других. Введите другие значения для расчётов.");
            }

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        public override double Square()
        {
            // вычисление периметра
            var perimeter = (Side1 + Side2 + Side3) / 2;
            //вычисление площади
            var square = Math.Sqrt(perimeter * (perimeter - Side1) * (perimeter - Side2) * (perimeter - Side3));

            return square;
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        public bool isStraightTriangle()
        {
            bool isStraight = (Side1 == Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side2, 2))
                    || Side2 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2))
                    || Side3 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2)));

            return isStraight;
        }
    }
}
