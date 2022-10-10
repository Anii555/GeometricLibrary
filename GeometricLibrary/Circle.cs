using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLibrary
{
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }

        public Circle(string typeName, double radius) : base(typeName)
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
        public override double Square()
        {
            return Math.Round(3.14f * Math.Pow(Radius, 2), 1);
        }
    }
}
