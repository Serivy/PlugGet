using System.Windows;

namespace ExampleApplicationWpf
{
    /// <summary>
    /// Interaction logic for PluginManager.xaml
    /// </summary>
    public partial class PluginManager : Window
    {
        public PluginManager()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
