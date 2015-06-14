using System.Drawing;

namespace ExampleApplication.Sdk
{
    public interface IColor
    {
        string Name { get; }

        Color Color { get; }
    }
}
