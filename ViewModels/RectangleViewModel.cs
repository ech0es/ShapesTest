using System;
using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public class RectangleViewModel : ShapeViewModel
    {
        private static readonly PropertyChangedEventArgs WidthChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Width));

        private static readonly PropertyChangedEventArgs HeightChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Height));

        private double _height;
        private double _width;

        public double Width
        {
            get => _width;
            set
            {
                if (_width != value)
                {
                    _width = Math.Abs(value);
                    NotifyPropertyChange(WidthChangedEventArgs);
                }
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                if (_height != value)
                {
                    _height = Math.Abs(value);
                    NotifyPropertyChange(HeightChangedEventArgs);
                }
            }
        }

        protected override double CalculateArea() => Width * Height;
    }
}