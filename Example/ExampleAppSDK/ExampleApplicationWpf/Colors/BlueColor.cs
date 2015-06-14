using System.Drawing;
using ExampleApplication.Sdk;

namespace ExampleApplication.Colors
{
    public class BlueColor : IColor
    {
        public string Name
        {
            get { return "Blue"; }
        }

        public Color Color
        {
            get { return Color.FromKnownColor(KnownColor.Blue); }
        }
    }
}
