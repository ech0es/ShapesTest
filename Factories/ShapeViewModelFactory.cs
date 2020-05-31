using System;
using System.Threading;
using ShapeTest.Enums;
using ShapeTest.ViewModels;

namespace ShapeTest.Factories
{
    public class ShapeViewModelFactory : IShapeViewModelFactory
    {
        private readonly Func<SquareViewModel> _squareFactory;
        private readonly Func<RectangleViewModel> _rectangleFactory;
        private readonly Func<TriangleViewModel> _triangleFactory;
        private readonly Func<CircleViewModel> _circleFactory;
        private readonly Func<CubeViewModel> _cubeFactory;
        private readonly Func<TetrahedronViewModel> _tetrahedronFactory;
        private readonly Func<ParallelepipedViewModel> _parallelepipedFactory;
        private readonly Func<BallViewModel> _ballFactory;

        public ShapeViewModelFactory(
            Func<SquareViewModel> squareFactory,
            Func<RectangleViewModel> rectangleFactory,
            Func<TriangleViewModel> triangleFactory,
            Func<CircleViewModel> circleFactory,
            Func<CubeViewModel> cubeFactory,
            Func<TetrahedronViewModel> tetrahedronFactory,
            Func<ParallelepipedViewModel> parallelepipedFactory,
            Func<BallViewModel> ballFactory)
        {
            _squareFactory = squareFactory;
            _rectangleFactory = rectangleFactory;
            _triangleFactory = triangleFactory;
            _circleFactory = circleFactory;
            _cubeFactory = cubeFactory;
            _tetrahedronFactory = tetrahedronFactory;
            _parallelepipedFactory = parallelepipedFactory;
            _ballFactory = ballFactory;
        }

        public ShapeViewModel CreateShape(Shapes type)
        {
            switch (type)
            {
                case Shapes.Square:
                    return _squareFactory();
                case Shapes.Rectangle:
                    return _rectangleFactory();
                case Shapes.Triangle:
                    return _triangleFactory();
                case Shapes.Circle:
                    return _circleFactory();
                case Shapes.Cube:
                    return _cubeFactory();
                case Shapes.Tetrahedron:
                    return _tetrahedronFactory();
                case Shapes.Parallelepiped:
                    return _parallelepipedFactory();
                case Shapes.Ball:
                    return _ballFactory();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}