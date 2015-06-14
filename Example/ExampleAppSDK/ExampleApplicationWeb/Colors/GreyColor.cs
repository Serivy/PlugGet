using System.Drawing;
using ExampleApplication.Sdk;

namespace ExampleApplicationWeb.Colors
{
    public class GrayColor : IColor
    {
        public string Name
        {
            get { return "Gray"; }
        }

        public Color Color
        {
            get { return Color.FromKnownColor(KnownColor.Gray); }
        }
    }
}
