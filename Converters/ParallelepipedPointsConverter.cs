using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Media3D;
using ShapeTest.ViewModels;

namespace ShapeTest.Converters
{
    public class ParallelepipedPointsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            var parallelepiped = (ParallelepipedViewModel) value;

            var maxRib = Math.Max(parallelepiped.Length, Math.Max(parallelepiped.Width, parallelepiped.Height));
            var height = parallelepiped.Height / maxRib;
            var width = parallelepiped.Width / maxRib;
            var length = parallelepiped.Length / maxRib;

            var points = new Point3DCollection();
            points.Add(new Point3D(-1, -1, -1));
            points.Add(new Point3D(width, -1, -1));
            points.Add(new Point3D(width, -1, length));
            points.Add(new Point3D(-1, -1, length));
            points.Add(new Point3D(-1, -1, length));
            points.Add(new Point3D(width, -1, length));
            points.Add(new Point3D(width, height, length));
            points.Add(new Point3D(-1, height, length));
            points.Add(new Point3D(width, -1, length));
            points.Add(new Point3D(width, -1, -1));
            points.Add(new Point3D(width, height, -1));
            points.Add(new Point3D(width, height, length));
            points.Add(new Point3D(width, height, length));
            points.Add(new Point3D(width, height, -1));
            points.Add(new Point3D(-1, height, -1));
            points.Add(new Point3D(-1, height, length));
            points.Add(new Point3D(-1, -1, length));
            points.Add(new Point3D(-1, height, length));
            points.Add(new Point3D(-1, height, -1));
            points.Add(new Point3D(-1, -1, -1));
            points.Add(new Point3D(-1, -1, -1));
            points.Add(new Point3D(-1, height, -1));
            points.Add(new Point3D(width, height, -1));
            points.Add(new Point3D(width, -1, -1));
            return points;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}