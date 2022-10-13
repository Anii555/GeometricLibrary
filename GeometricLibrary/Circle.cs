using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным.");
            }

            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>        
        public double Square()
        {
            return Math.Round(3.14f * Math.Pow(Radius, 2), 1);
        }
    }
}
