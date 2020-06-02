using System;
using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public class TetrahedronViewModel : ShapeViewModel
    {
        private const double Sqrt3 = 1.732050808;
        private const double Sqrt2Divided12 = 0.11785113;

        private static readonly PropertyChangedEventArgs LengthChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Length));

        private double _length;

        public TetrahedronViewModel()
        {
            NotifyPropertyChange(LengthChangedEventArgs);
        }

        public double Length
        {
            get => _length;
            set
            {
                if (_length != value)
                {
                    _length = Math.Abs(value);
                    NotifyPropertyChange(LengthChangedEventArgs);
                }
            }
        }

        protected override double CalculateArea() => Sqrt3 * Length * Length;

        protected override double? CalculateVolume() => Math.Pow(Length, 3) * Sqrt2Divided12;
    }
}