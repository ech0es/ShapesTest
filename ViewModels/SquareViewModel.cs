using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public class SquareViewModel : ShapeViewModel
    {
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

        protected override double CalculateArea() => Length * Length;
    }
}