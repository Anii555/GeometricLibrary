namespace GeometricLibrary
{
    public abstract class Shape
    {
        public string TypeName { get; set; }

        public Shape(string typeName)
        {
            TypeName = typeName;
        }

        public abstract double Square();

    }
}