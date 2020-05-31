using System;
using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public class BallViewModel : ShapeViewModel
    {
        private const double FourDivided3MultipliedPi = 4.188790205;

        private static readonly PropertyChangedEventArgs RadiusChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Radius));

        private double _radius;

        public BallViewModel()
        {
            NotifyPropertyChange(RadiusChangedEventArgs);
        }

        public double Radius
        {
            get => _radius;
            set
            {
                if (_radius != value)
                {
                    _radius = value;
                    NotifyPropertyChange(RadiusChangedEventArgs);
                }
            }
        }

        protected override double CalculateArea() => 4 * Radius * Radius * Math.PI;

        protected override double? CalculateVolume() => FourDivided3MultipliedPi * Math.Pow(Radius, 3);
    }
}