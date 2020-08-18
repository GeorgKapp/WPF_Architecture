using System.ComponentModel;
using System.Windows;

namespace WPF_Architecture_Custom.WPF_Base_Classes
{
    /// <summary>
    /// Uses PropertyChanged.dll that adds OnPropertyChanged Method to all properties during compile time in a window class
    /// </summary>
#pragma warning disable CS0067
    public class WindowBase : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
#pragma warning restore CS0067
}
