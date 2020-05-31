using System.Collections.ObjectModel;
using System.Windows;
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

        public ShapeList()
        {
            InitializeComponent();
        }

        public ObservableCollection<ShapeViewModel> Shapes
        {
            get => (ObservableCollection<ShapeViewModel>) GetValue(ShapesProperty);
            set => SetValue(ShapesProperty, value);
        }
    }
}