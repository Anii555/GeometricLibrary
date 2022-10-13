using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricLibrary.UnitTest
{
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// Тест стандартного круга
        /// </summary>
        [TestMethod]
        public void Circle_data()
        {
            // Arrange
            var circle = new Circle(13.3);
            double expected = 555;

            // Act
            var result = Math.Round(circle.Square());

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Тест круга с нулевым радиусом
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "Радиус должен быть положительным.")]
        public void isExistWithIncorrectRadius()
        {
            var circle = new Circle(0);
        }
    }
}