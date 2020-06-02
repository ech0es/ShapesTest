using Autofac;
using ShapeTest.Factories;
using ShapeTest.ViewModels;

namespace ShapeTest
{
    public class Bootstrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SquareViewModel>().AsSelf();
            builder.RegisterType<RectangleViewModel>().AsSelf();
            builder.RegisterType<TriangleViewModel>().AsSelf();
            builder.RegisterType<CircleViewModel>().AsSelf();
            builder.RegisterType<CubeViewModel>().AsSelf();
            builder.RegisterType<TetrahedronViewModel>().AsSelf();
            builder.RegisterType<ParallelepipedViewModel>().AsSelf();
            builder.RegisterType<BallViewModel>().AsSelf();
            builder.RegisterType<SquareViewModel>().AsSelf();
            builder.RegisterType<AddShapeCommand>().AsSelf().SingleInstance();
            builder.RegisterType<RemoveShapeCommand>().AsSelf().SingleInstance();
            builder.RegisterType<ShapeViewModelFactory>().AsImplementedInterfaces();

            return builder.Build();
        }
    }
}