namespace GeometricLibrary
{
    public abstract class Shape
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string TypeName { get; set; }

        public Shape(string typeName)
        {
            TypeName = typeName;
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        public abstract double Square();

    }
}