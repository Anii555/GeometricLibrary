using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricLibrary.UnitTest
{
    [TestClass]
    public class TriangleTest
    {

        /// <summary>
        /// Тест на вычисление площади
        /// </summary>
        [TestMethod]
        public void TriangleSquare()
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
        /// Тест треугольника на прямоугольность
        /// </summary>
        [TestMethod]
        public void IsStraightTriangle()
        {
            // Arrage
            var triangle333 = new Triangle(3, 3, 3);

            // Act
            var triangleCheck = triangle333.IsStraightTriangle();
            var localCheck = LocalStraightCheck(triangle333);

            // Assert
            Assert.AreEqual(triangleCheck, localCheck);
        }

        /// <summary>
        /// Локальная проверка на то, является ли треугольник прямоугольным.
        /// Метод учитывает возможность изменения тестир-го метода другими разработчиками.
        /// </summary>
        public bool LocalStraightCheck(Triangle triangle333)
        {
            bool isStraight = (triangle333.Side1 == Math.Sqrt(Math.Pow(triangle333.Side2, 2) + Math.Pow(triangle333.Side2, 2))
                    || triangle333.Side2 == Math.Sqrt(Math.Pow(triangle333.Side1, 2) + Math.Pow(triangle333.Side3, 2))
                    || triangle333.Side3 == Math.Sqrt(Math.Pow(triangle333.Side1, 2) + Math.Pow(triangle333.Side2, 2)));

            return isStraight;
        }

        /// <summary>
        /// Тест треугольника со стороной - большей суммы двух других (1,2,7)
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "Сторона треугольника не может быть больше суммы двух других. Введите другие значения для расчётов.")]
        public void IncorrectSides()
        {
            var triangle = new Triangle(1, 2, 7);
        }

        /// <summary>
        /// Тест треугольника с нулевой стороной
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "Сторона(ы) треугольника не могут быть меньше 0.Введите другие значения для расчётов.")]
        public void NotPositiveSides()
        {
            var triangle = new Triangle(0, 1, 1);
        }
    }
}