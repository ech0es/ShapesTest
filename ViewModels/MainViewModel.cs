using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ShapeViewModel> Shapes { get; } = new ObservableCollection<ShapeViewModel>();

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
}