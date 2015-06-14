using System.ComponentModel.Composition;
using System.Drawing;
using ExampleApplication.Sdk;

namespace BuiltInPlugin.Colors
{
    [Export(typeof(IColor))]
    public class RedColor : IColor
    {
        public string Name
        {
            get { return "Red"; }
        }

        public Color Color
        {
            get { return System.Drawing.Color.FromKnownColor(KnownColor.Red); }
        }
    }
}
