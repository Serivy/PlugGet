using ExampleApplication.Sdk;

namespace ExampleApplicationWeb.Shapes
{
    class Curve : IShape
    {
        public string Name
        {
            get { return "Curve"; }
        }

        public string Path
        {
            get { return "M 100,200 C 100,25 400,350 400,175 H 280"; }
        }
    }
}
