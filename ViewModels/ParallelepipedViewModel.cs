using System;
using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public class ParallelepipedViewModel : ShapeViewModel
    {
        private static readonly PropertyChangedEventArgs WidthChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Width));

        private static readonly PropertyChangedEventArgs HeightChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Height));

        private static readonly PropertyChangedEventArgs LengthChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Length));

        private double _height;
        private double _length;
        private double _width;

        public ParallelepipedViewModel()
        {
            NotifyPropertyChange(HeightChangedEventArgs);
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

        protected override double CalculateArea() =>  2 * (Width * Height + Width * Length + Height * Length);

        protected override double? CalculateVolume() => Width * Height * Length;
    }
}