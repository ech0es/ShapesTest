using System;
using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public class CubeViewModel : ShapeViewModel
    {
        private static readonly PropertyChangedEventArgs LengthChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Length));

        private double _length;

        public CubeViewModel()
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

        protected override double CalculateArea() => 6 * Length * Length;

        protected override double? CalculateVolume() => Math.Pow(Length, 3);
    }
}