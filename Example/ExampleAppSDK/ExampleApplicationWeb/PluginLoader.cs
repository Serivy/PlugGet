using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using ExampleApplication.Sdk;

namespace ExampleApplicationWeb
{
    public class PluginLoader
    {
        [ImportMany(typeof(IColor))]
        public IEnumerable<IColor> Colors;

        [ImportMany(typeof(IShape))]
        public IEnumerable<IShape> Shapes;

        public void Import(string path)
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(path));
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }
}