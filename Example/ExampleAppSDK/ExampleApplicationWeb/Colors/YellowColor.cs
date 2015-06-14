using System.Drawing;
using ExampleApplication.Sdk;

namespace ExampleApplicationWeb.Colors
{
    public class YellowColor : IColor
    {
        public string Name
        {
            get { return "Yellow"; }
        }

        public Color Color
        {
            get { return System.Drawing.Color.FromKnownColor(KnownColor.Yellow); }
        }
    }
}
