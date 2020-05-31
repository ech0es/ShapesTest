using System.ComponentModel;

namespace ShapeTest.ViewModels
{
    public abstract class ShapeViewModel : INotifyPropertyChanged
    {
        private static readonly PropertyChangedEventArgs AreaChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Area));

        private static readonly PropertyChangedEventArgs VolumeChangedEventArgs =
            new PropertyChangedEventArgs(nameof(Volume));

        public double Area { get; private set; }

        public double? Volume { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected abstract double CalculateArea();

        protected virtual double? CalculateVolume()
        {
            return null;
        }

        protected void NotifyPropertyChange(PropertyChangedEventArgs propertyChangedEventArgs)
        {
            Area = CalculateArea();
            Volume = CalculateVolume();

            PropertyChanged?.Invoke(this, propertyChangedEventArgs);
            PropertyChanged?.Invoke(this, AreaChangedEventArgs);
            PropertyChanged?.Invoke(this, VolumeChangedEventArgs);
        }
    }
}