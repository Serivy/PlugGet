using System.Drawing;
using ExampleApplication.Sdk;

namespace ExampleApplication.Colors
{
    public class BlackColor : IColor
    {
        public string Name
        {
            get { return "Black"; }
        }

        public Color Color
        {
            get { return System.Drawing.Color.FromKnownColor(KnownColor.Black); }
        }
    }
}
