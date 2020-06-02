using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ShapeTest.Enums;
using ShapeTest.Factories;

namespace ShapeTest.ViewModels
{
    public class AddShapeCommand : ICommand
    {
        private readonly ObservableCollection<ShapeViewModel> _shapes;
        private readonly IShapeViewModelFactory _shapeViewModelFactory;

        public AddShapeCommand(
            IShapeViewModelFactory shapeViewModelFactory,
            ObservableCollection<ShapeViewModel> shapes)
        {
            _shapeViewModelFactory = shapeViewModelFactory;
            _shapes = shapes;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var shapeViewModel = _shapeViewModelFactory.CreateShape((Shapes) parameter);
            _shapes.Add(shapeViewModel);
        }

        public event EventHandler CanExecuteChanged;
    }
}