using System.Windows.Input;

namespace WPF_Architecture
{
    public class ViewModel : ViewModelBase
    {
        public ICommand ChangeNameCommand => _changeNameCommand;
        private readonly DelegateCommand _changeNameCommand;

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        public ViewModel()
        {
            _changeNameCommand = new DelegateCommand(OnChangeName, CanChangeName);
        }

        private void OnChangeName(object commandParameter)
        {
            FirstName = "Walter";
            _changeNameCommand.InvokeCanExecuteChanged();
        }

        private bool CanChangeName(object commandParameter)
        {
            return FirstName != "Walter";
        }
    }
}
