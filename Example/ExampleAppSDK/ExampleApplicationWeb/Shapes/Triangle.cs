using ExampleApplication.Sdk;

namespace ExampleApplicationWeb.Shapes
{
    class Triangle : IShape
    {
        public string Name
        {
            get { return "Triangle"; }
        }

        public string Path
        {
            get { return "M150 0 L75 200 L225 200 Z"; }
        }
    }
}
