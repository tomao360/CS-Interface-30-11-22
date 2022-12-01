using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_TheInterface
{
    internal class Rectangle : IShape
    {
        public string Color()
        {
            return RectangleColor;
        }
        public double FrameThickness()
        {
            return Length * Width;
        }
        public int VerticesNum()
        {
            return 4;
        }

        private string _rectangleColor;
        public string RectangleColor
        {
            get { return _rectangleColor; }
            set { _rectangleColor = value; }
        }

        private int _length;
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        private int _width;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
    }

    internal class Circle : IShape
    {
        public string Color()
        {
            return CircleColor;
        }
        public double FrameThickness()
        {
            return 2 * 3.14 * RadiusLength;
        }
        public int VerticesNum()
        {
            return 0;
        }

        private string _circleColor;
        public string CircleColor
        {
            get { return _circleColor; }
            set { _circleColor = value; }
        }

        private int _radiusLength;
        public int RadiusLength
        {
            get { return _radiusLength; }
            set { _radiusLength = value; }
        }
        public void Roll()
        {
            MessageBox.Show("The shape has rolled!");
        }
    }

    internal class Ellipse : Circle
    {
        private int _radiusLength2;
        public int RadiusLength2
        {
            get { return _radiusLength2; }
            set { _radiusLength2 = value; }
        }
        public double FrameThicknessElipsa()
        {
            return 3.14 * RadiusLength2 * RadiusLength;
        }
    }

    internal class Triangle : IShape
    {
        public string Color()
        {
            return TriangleColor;
        }
        public double FrameThickness()
        {
            return BaseWidth * Height / 2;
        }
        public int VerticesNum()
        {
            return 3;
        }

        private string _triangleColor;
        public string TriangleColor
        {
            get { return _triangleColor; }
            set { _triangleColor = value; }
        }

        private int _baseWidth;
        public int BaseWidth
        {
            get { return _baseWidth; }
            set { _baseWidth = value; }
        }

        public int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
    }

    internal class Moon : IShape
    {
        public string Color()
        {
            return MoonColor;
        }
        public double FrameThickness()
        {
            return DistanceBetweenTwoSides * 3.14;
        }
        public int VerticesNum()
        {
            return 2;
        }

        private string _moonColor;
        public string MoonColor
        {
            get { return _moonColor; }
            set { _moonColor = value; }
        }

        private int _distanceBetweenTwoSides;
        public int DistanceBetweenTwoSides
        {
            get { return _distanceBetweenTwoSides; }
            set { _distanceBetweenTwoSides = value; }
        }
        public void Roll()
        {
            MessageBox.Show("The shape has rolled!");
        }
    }
}

