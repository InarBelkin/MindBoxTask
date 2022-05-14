using System;
using System.Collections.ObjectModel;

namespace FigureLibrary.MainFigures
{
    public class Triangle : Figure
    {
        public override double Area => _area;
        private double _area;

        public ReadOnlyCollection<double> Sides { get; private set; }

        public bool IsRightAngled { get; private set; }

        private void _makeTriangle(double a, double b, double c)
        {
            if (a >= b + c || b >= a + c || c >= a + b)
                throw new ArgumentException("triangle with these sides lengths doesn't exists");

            Sides = Array.AsReadOnly(new[] {a, b, c});

            var halfPerimeter = (a + b + c) / 2;
            var halfSum = halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c);
            _area = Math.Sqrt(halfSum);

            IsRightAngled = (Math.Abs(a * a - (b * b + c * c)) < Constants.Tolerance ||
                             Math.Abs(b * b - (a * a + c * c)) < Constants.Tolerance ||
                             Math.Abs(c * c - (a * a + b * b)) < Constants.Tolerance);
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            _makeTriangle(sideA, sideB, sideC);
        }

        public Triangle(params double[] sides)
        {
            if (sides.Length != 3) throw new ArgumentException("sides count is wrong");
            _makeTriangle(sides[0], sides[1], sides[2]);
        }
    }
}