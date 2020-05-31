using ShapeTest.Enums;
using ShapeTest.ViewModels;

namespace ShapeTest.Factories
{
    public interface IShapeViewModelFactory
    {
        ShapeViewModel CreateShape(Shapes type);
    }
}