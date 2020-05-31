using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Autofac.Extras.CommonServiceLocator;
using ShapeTest.Factories;

namespace ShapeTest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IShapeViewModelFactory _shapeViewModelFactory;
        public ObservableCollection<ShapeViewModel> Shapes { get; } = new ObservableCollection<ShapeViewModel>();

        public ICommand AddShapeCommand { get; }

        public MainViewModel()
        {
            var localIoc = new AutofacServiceLocator(new Bootstrapper().BootStrap());
            AddShapeCommand = localIoc.GetInstance<AddShapeCommand>();
            ((AddShapeCommand) AddShapeCommand).Shapes = Shapes; // the worst DI I have seen BTW((
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}