using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidGame
{
    internal abstract class ImageObject : VisualObject
    {
        private readonly Image _Image;
        public ImageObject(Point Position, Point Direction, Size Size, Image Image) 
            : base(Position, Direction, Size)
        {
            _Image = Image;
        }
    }

    internal class SunStar : ImageObject
    {
        private static readonly Image __Image = Image.FromFile("src\\StarSun.jpg");
        public SunStar(Point Position, Point Direction, int ImageSize)
            : base(Position, Direction, new Size(ImageSize, ImageSize), __Image)
        {
        }
    }
}
