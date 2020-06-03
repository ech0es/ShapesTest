using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using ShapeTest.ViewModels;

namespace ShapeTest.Views
{
    public partial class ShapePreview
    {
        public static readonly DependencyProperty ShapeProperty = DependencyProperty.Register(
            "Shape", 
            typeof(ShapeViewModel), 
            typeof(ShapePreview), 
            new PropertyMetadata(default(ShapeViewModel)));

        public ShapePreview()
        {
            InitializeComponent();
        }

        public ShapeViewModel Shape
        {
            get => (ShapeViewModel) GetValue(ShapeProperty);
            set => SetValue(ShapeProperty, value);
        }
    }
}