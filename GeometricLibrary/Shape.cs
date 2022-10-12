namespace GeometricLibrary
{
    /// <summary>
    /// Интерфейс взаимодействия с любымой фигурой
    /// </summary>
    public class Shape
    {
        /// <summary>
        /// Получение площади круга
        /// </summary>
        public double GetCircleSquare(double radius)
        {
            return new Circle(radius).Square();
        }

        /// <summary>
        /// Получение площади треугольника
        /// </summary>
        public double GetTriangleSquare(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3).Square();
        }
    }
}