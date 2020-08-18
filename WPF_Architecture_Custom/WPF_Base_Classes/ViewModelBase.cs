using PropertyChanged;
using System;
using System.ComponentModel;

namespace WPF_Architecture_Custom.WPF_Base_Classes
{
    /// <summary>
    /// Uses PropertyChanged.dll that adds OnPropertyChanged Method to all properties during compile time in a viewmodel class
    /// </summary>
#pragma warning disable CS0067
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
#pragma warning restore CS0067
}
