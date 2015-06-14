using System;
using System.Collections.Generic;
using System.IO;
using ExampleApplication.Sdk;
using ExampleApplicationWeb.Colors;
using ExampleApplicationWeb.Shapes;

namespace ExampleApplicationWeb
{
    public static class Instance
    {
        public static List<IColor> Colors = new List<IColor>();
        public static List<IShape> Shapes = new List<IShape>();

        static Instance()
        {
            var loader = new PluginLoader();
            var binDirectory = Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "..\\bin");
            loader.Import(binDirectory);

            Colors.Add(new GrayColor());
            Colors.Add(new YellowColor());
            foreach (var color in loader.Colors)
            {
                Colors.Add(color);
            }

            Shapes.Add(new Triangle());
            Shapes.Add(new Curve());
            foreach (var shape in loader.Shapes)
            {
                Shapes.Add(shape);
            }
        }
    }
}