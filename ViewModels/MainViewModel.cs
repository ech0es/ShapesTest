using System;
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

        public ICommand RemoveShapeCommand { get; }

        public MainViewModel()
        {
            var localIoc = new AutofacServiceLocator(new Bootstrapper().BootStrap());
            var addShapeCommandFactory = localIoc.GetInstance<Func<ObservableCollection<ShapeViewModel>, AddShapeCommand>>();
            var removeShapeCommandFactory = localIoc.GetInstance<Func<ObservableCollection<ShapeViewModel>, RemoveShapeCommand>>();

            AddShapeCommand = addShapeCommandFactory(Shapes);
            RemoveShapeCommand = removeShapeCommandFactory(Shapes);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}