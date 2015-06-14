using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using ExampleApplication;
using ExampleApplication.Colors;
using ExampleApplication.Sdk;
using ExampleApplication.Shapes;

namespace ExampleApplicationWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<IColor> Colors = new List<IColor>();
        public List<IShape> Shapes = new List<IShape>();

        public MainWindow()
        {
            InitializeComponent();
            var importer = new PluginLoader();
            importer.Import(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            // Add base colors and then ones from plugins.
            Colors.Add(new BlackColor());
            Colors.Add(new BlueColor());
            foreach (var color in importer.Colors)
            {
                Colors.Add(color);
            }

            // Add base shapes and then ones from plugins.
            Shapes.Add(new Triangle());
            Shapes.Add(new Curve());
            foreach (var shape in importer.Shapes)
            {
                Shapes.Add(shape);
            }

            ColorList.ItemsSource = Colors;
            ColorList.SelectedIndex = 0;
            ColorList.SelectionChanged += Redraw;
            ShapeList.ItemsSource = Shapes;
            ShapeList.SelectedIndex = 0;
            ShapeList.SelectionChanged += Redraw;
            Redraw();
        }

        void Redraw(object sender, SelectionChangedEventArgs e)
        {
            Redraw();
        }

        private void Redraw()
        {
            Canvas.Children.Clear();

            var color = ((IColor)ColorList.SelectedValue).Color;
            var shape = (IShape)ShapeList.SelectedValue;

            var path = new Path() 
            {
                Data = Geometry.Parse(shape.Path), 
                Stroke = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B))
            };
            Canvas.Children.Add(path);
        }

        private void OpenExtension(object sender, RoutedEventArgs e)
        {
            var plugin = new PluginManager();
            plugin.ShowDialog();
        }
    }
}
