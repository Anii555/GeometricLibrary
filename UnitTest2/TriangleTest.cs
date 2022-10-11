using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricLibrary.UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle_data()
        {
            // Arrange
            var triangle = new Triangle("Треугольник", 3, 4, 5);
            double expected = 6;

            // Act
            var result = triangle.Square();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isStraightTriangle_data()
        {
            // Arrange
            var triangle = new Triangle("Треугольник", 2, 3, 4);

            // Act
            var result = triangle.isStraightTriangle();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "Сторона треугольника не может быть больше суммы двух других. Введите другие значения для расчётов.")]
        public void isExist()
        {
            // Arrange
            var triangle = new Triangle("Треугольник", 1, 2, 7);

            // Act
            var result = triangle.isStraightTriangle();

            // Assert
            Assert.IsFalse(result);
        }
    }
}