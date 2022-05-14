using System;

namespace FigureLibrary.MainFigures
{
    public class Circle : Figure
    {
        public override double Area { get; }

        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * Radius * Radius;
        }

        public bool Equals(Circle other)
        {
            return Math.Abs(other.Radius - Radius) < Constants.Tolerance;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Circle)) return false;
            return Equals((Circle) obj);
        }

        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }

        public static bool operator ==(Circle left, Circle right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Circle left, Circle right)
        {
            return !Equals(left, right);
        }
    }
}