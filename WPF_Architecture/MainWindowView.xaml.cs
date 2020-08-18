using System.Windows;

namespace WPF_Architecture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            var viewModel = new ViewModel();
            viewModel.FirstName = "Kevin";
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
