using System.ComponentModel.Composition;
using System.Drawing;
using ExampleApplication.Sdk;

namespace BuiltInPlugin.Colors
{
    [Export(typeof(IColor))]
    public class PurpleColor : IColor
    {
        public string Name
        {
            get { return "Purple"; }
        }

        public Color Color
        {
            get { return Color.FromKnownColor(KnownColor.Purple); }
        }
    }
}
