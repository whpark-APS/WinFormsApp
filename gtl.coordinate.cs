using System;

namespace gtl.coordinate
{

    public struct Point
    {
        public double x, y;

        public Point(double _x = .0, double _y = .0) => (x, y) = (_x, _y);

        public override string ToString() => $"({x},{y})";

        public Point GetNoralized() {
            var v = new Point(x, y);
            v.Normalize();
            return v;
        }

        public void Normalize() => (x, y) = (x / Length(), y / Length());

        public double Length() => Math.Sqrt(x*x + y*y);

    }


    public struct Point3
    {
        public double x, y, z;

        public Point3(double _x = .0, double _y = .0, double _z = .0) => (x, y, z) = (_x, _y, _z);

        public override string ToString() => $"({x},{y},{z})";

        public void Normalize() => (x, y, z) = (x / Length(), y / Length(), z / Length());

        public double Length() => Math.Sqrt(x*x + y*y + z*z);
    }

#if false
    public struct Point<T>
    {
        public T x, y;

        public Point(T _x, T _y) => (x, y) = (_x, _y);

        public override string ToString() => $"({x},{y})";

        public Point<T> GetNoralized()
        {
            var v = new Point<T>(x, y);
            v.Normalize();
            return v;
        }

        public void Normalize()
        {
            double l = Length();
            //x /= l;
            //y /= l;
        }

        public double Length()
        {
            double v = Math.Sqrt((double)(object)x * (double)(object)x + (double)(object)y * (double)(object)y);
            return v;
        }

        public static double Length(Point<T> pt) where T : IFloatingPoint<T>
        {

        }

    }


    public struct Point3<T>
    {
        public T x, y, z;

        public Point3(T _x, T _y, T _z) => (x, y, z) = (_x, _y, _z);

        public override string ToString() => $"({x},{y},{z})";
    }
#endif
}
