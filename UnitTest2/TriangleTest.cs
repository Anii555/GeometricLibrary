using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricLibrary.UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Тест обычного треугольника со сторонамм 3,4,5
        /// </summary>
        [TestMethod]
        public void Triangle_data()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            double expected = 6;

            // Act
            var result = triangle.Square();

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Тест треугольника на прямоугольность (2,3,4)
        /// </summary>
        [TestMethod]
        public void isStraightTriangle_data()
        {
            // Arrange
            var triangle333 = new Triangle(3, 3, 3);
            var triangle345 = new Triangle(3, 4, 5);

            Assert.IsTrue(isStraightTriangle(triangle345));
            Assert.IsFalse(isStraightTriangle(triangle333));
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        public bool isStraightTriangle(Triangle triangle)
        {
            bool isStraight = (triangle.Side1 == Math.Sqrt(Math.Pow(triangle.Side2, 2) + Math.Pow(triangle.Side2, 2))
                    || triangle.Side2 == Math.Sqrt(Math.Pow(triangle.Side1, 2) + Math.Pow(triangle.Side3, 2))
                    || triangle.Side3 == Math.Sqrt(Math.Pow(triangle.Side1, 2) + Math.Pow(triangle.Side2, 2)));

            return isStraight;
        }


        /// <summary>
        /// Тест треугольника со стороной - большей суммы двух других (1,2,7)
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "Сторона треугольника не может быть больше суммы двух других. Введите другие значения для расчётов.")]
        public void isExist()
        {
            var triangle = new Triangle(1, 2, 7);
        }

        /// <summary>
        /// Тест треугольника с нулевой стороной
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "Сторона(ы) треугольника не могут быть меньше 0.Введите другие значения для расчётов.")]
        public void isExistWithNullSides()
        {
            var triangle = new Triangle(0, 1, 1);
        }
    }
}