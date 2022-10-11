using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricLibrary.UnitTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square_data()
        {
            // Arrange
            var circle = new Circle("Круг", 13.3);
            double expected = 555;

            // Act
            var result = Math.Round(circle.Square());

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}