using System.Windows;
using WPF_Architecture_Custom.WPF_Base_Classes;

namespace WPF_Architecture_Custom.WPF_Content.Window
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : WindowBase
    {
        private ViewController _controller;
        public ViewModel ViewModel { get; set; } = new ViewModel();

        public MainWindow(ViewController controller)
        {
            InitializeComponent();
            _controller = controller;
            ViewModel = _controller.GetTestModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _controller.UpdateModel(ViewModel);
        }
    }
}
