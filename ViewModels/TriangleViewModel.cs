using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public class TriangleViewModel : ShapeViewModel
    {
        private const double Sqrt3Divided4 = 6.92820323;

        private static readonly PropertyChangedEventArgs LengthChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Length));

        private double _length;

        public double Length
        {
            get => _length;
            set
            {
                if (_length != value)
                {
                    _length = value;
                    NotifyPropertyChange(LengthChangedEventArgs);
                }
            }
        }

        protected override double CalculateArea() => Length * Length * Sqrt3Divided4;
    }
}