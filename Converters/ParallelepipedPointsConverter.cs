using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Media3D;
using ShapeTest.ViewModels;

namespace ShapeTest.Converters
{
    public class ParallelepipedPointsConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length == 0 || !(values[0] is ParallelepipedViewModel)) return null;

            var parallelepiped = (ParallelepipedViewModel)values[0];

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

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}