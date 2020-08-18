using System.Windows;
using WPF_Architecture_Custom.WPF_Content;
using WPF_Architecture_Custom.WPF_Content.Window;

namespace WPF_Architecture_Custom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            MainWindow window = new MainWindow(new ViewController());
            window.ShowDialog();
        }
    }
}
