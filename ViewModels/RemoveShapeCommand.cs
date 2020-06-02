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
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _shapes.Remove((ShapeViewModel) parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}