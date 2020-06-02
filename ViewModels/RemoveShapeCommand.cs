using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ShapeTest.ViewModels
{
    public class RemoveShapeCommand : ICommand
    {
        private readonly ObservableCollection<ShapeViewModel> _shapes;

        public RemoveShapeCommand(ObservableCollection<ShapeViewModel> shapes)
        {
            _shapes = shapes;
            CommandManager.RequerySuggested += CommandManagerOnRequerySuggested;
        }

        public bool CanExecute(object parameter)
        {
            return parameter != null;
        }

        public void Execute(object parameter)
        {
            _shapes.Remove((ShapeViewModel) parameter);
        }

        public event EventHandler CanExecuteChanged;

        private void CommandManagerOnRequerySuggested(object sender, EventArgs e)
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}