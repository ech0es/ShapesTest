using System;
using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public class CircleViewModel : ShapeViewModel
    {
        private static readonly PropertyChangedEventArgs RadiusChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Radius));

        private double _radius;

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

        protected override double CalculateArea() => Radius * Radius * Math.PI;
    }
}