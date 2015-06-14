using System.ComponentModel.Composition;
using ExampleApplication.Sdk;

namespace BuiltInPlugin.Shapes
{
    [Export(typeof(IShape))]
    class Hex : IShape
    {
        public string Name
        {
            get { return "Hex"; }
        }

        public string Path
        {
            get { return "M 60 0 L 120 0 L 180 60 L 180 120 L 120 180 L 60 180 L 0 120 L 0 60"; }
        }
    }
}
