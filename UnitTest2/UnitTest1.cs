using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricLibrary.UnitTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Square_data()
        {
            var circle = new Circle("Круг", 13.3);
            double expected = 555;

            var result = Math.Round(circle.Square());

            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_data()
        {
            var triangle = new Triangle("Треугольник", 3, 4, 5);
            double expected = 6;

            var result = triangle.Square();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isStraightTriangle_data()
        {
            var triangle = new Triangle("Треугольник", 1, 2, 7);

            var result = triangle.isStraightTriangle();

            Assert.IsFalse(result);
        }
    }
}