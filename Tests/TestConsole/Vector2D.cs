using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public double Angle => Math.Atan2(Y, X);

        public Vector2D() { }

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X - b.X, a.Y - b.Y);
        }

        public static Vector2D operator +(Vector2D a, double x)
        {
            return new Vector2D(a.X + x, a.Y + x);
        }

        public static implicit operator double(Vector2D vector)
        {
            return vector.Length;
        }

        public static explicit operator int(Vector2D vector)
        {
            return (int)Math.Round(vector.Length);
        }
    }

    public struct Vector2DStruct
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2DStruct(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
