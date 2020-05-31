using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace ShapeTest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ShapeViewModel> Shapes { get; } = new ObservableCollection<ShapeViewModel>();

        public ICommand AddShapeCommand { get; } = new AddShapeCommand();

        public MainViewModel()
        {
            Shapes.Add(new SquareViewModel());
            Shapes.Add(new RectangleViewModel());
            Shapes.Add(new TriangleViewModel());
            Shapes.Add(new CircleViewModel());
            Shapes.Add(new CubeViewModel());
            Shapes.Add(new TetrahedronViewModel());
            Shapes.Add(new ParallelepipedViewModel());
            Shapes.Add(new BallViewModel());
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class AddShapeCommand : ICommand
    {
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            parameter.ToString();
        }

        public event EventHandler CanExecuteChanged;
    }
}