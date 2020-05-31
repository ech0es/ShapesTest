using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ShapeTest.Enums;
using ShapeTest.Factories;

namespace ShapeTest.ViewModels
{
    public class AddShapeCommand : ICommand
    {
        private readonly IShapeViewModelFactory _shapeViewModelFactory;

        public AddShapeCommand(IShapeViewModelFactory shapeViewModelFactory)
        {
            _shapeViewModelFactory = shapeViewModelFactory;
        }

        internal ObservableCollection<ShapeViewModel> Shapes { get; set; }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            var shapeViewModel = _shapeViewModelFactory.CreateShape(((Shapes)parameter));
            Shapes.Add(shapeViewModel);
        }

        public event EventHandler CanExecuteChanged;
    }
}