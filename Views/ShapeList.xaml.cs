using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ShapeTest.ViewModels;

namespace ShapeTest.Views
{
    public partial class ShapeList
    {
        public static readonly DependencyProperty ShapesProperty = DependencyProperty.Register(
            "Shapes",
            typeof(ObservableCollection<ShapeViewModel>),
            typeof(ShapeList),
            new PropertyMetadata(default(ObservableCollection<ShapeViewModel>)));

        public static readonly DependencyProperty RemoveShapeCommandProperty = DependencyProperty.Register(
            "RemoveShapeCommand",
            typeof(ICommand),
            typeof(ShapeList),
            new PropertyMetadata(default(ICommand)));

        public static readonly DependencyProperty SelectedShapeProperty = DependencyProperty.Register(
            "SelectedShape",
            typeof(ShapeViewModel),
            typeof(ShapeList),
            new PropertyMetadata(default(ShapeViewModel)));

        public ShapeList()
        {
            InitializeComponent();
        }

        public ObservableCollection<ShapeViewModel> Shapes
        {
            get => (ObservableCollection<ShapeViewModel>) GetValue(ShapesProperty);
            set => SetValue(ShapesProperty, value);
        }

        public ICommand RemoveShapeCommand
        {
            get => (ICommand) GetValue(RemoveShapeCommandProperty);
            set => SetValue(RemoveShapeCommandProperty, value);
        }

        public ShapeViewModel SelectedShape
        {
            get => (ShapeViewModel) GetValue(SelectedShapeProperty);
            set => SetValue(SelectedShapeProperty, value);
        }
    }
}