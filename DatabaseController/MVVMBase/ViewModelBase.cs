using DatabaseController.CommandExecutors.ViewModel;
using DatabaseController.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMBase
{
    class ViewModelBase : INotifyPropertyChanged
    {
        protected static MainWindowVM _mainWindow;
        public MainWindowVM MainWindow {get => _mainWindow;}

        public event PropertyChangedEventHandler PropertyChanged;

        //metoda zgłaszająca zmiany we własnościach podanych jako argumenty
        protected void OnPropertyChanged(params string[] namesOfProperties)
        {
            if (PropertyChanged != null)
            {
                foreach (var prop in namesOfProperties)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
                }
            }
        }
    }
    class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));
            else
                _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null) CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_canExecute != null) CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }

    class DisplayCECommand : ICommand
    {
        readonly Predicate<object> _canExecute;
        Func<object, CommandFormVM> _commandForm;

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            var win = new Window();
            win.Content = new CommandExecutorWindowVM(_commandForm(parameter));
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ShowDialog();
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null) CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_canExecute != null) CommandManager.RequerySuggested -= value;
            }
        }

        public DisplayCECommand(Func<object, CommandFormVM> commandForm, Predicate<object> canExecute = null)
        {
            if (commandForm == null)
                throw new ArgumentNullException(nameof(commandForm));
            else
                _commandForm = commandForm;
            _canExecute = canExecute;
        }
    }
}
