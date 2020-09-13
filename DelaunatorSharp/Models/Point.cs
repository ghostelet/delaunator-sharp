using System;

namespace DelaunatorSharp
{
    public struct Point : IPoint, IEquatable<Point>
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"{X},{Y}";

        public bool Equals(Point other) => this.X == other.X && this.Y == other.Y;

        public override bool Equals(object obj) => obj is Point other && this.Equals(other);

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 92821;
                hash = 486187739 * hash + this.X.GetHashCode();
                hash = 486187739 * hash + this.Y.GetHashCode();
                return hash;
            }
        }
    }

}
