using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidGame
{   //создали абстрактный класс для изображений и от него наследуем класс солнце для отрисовки солнца
    internal abstract class ImageObject : VisualObject
    {
        private readonly Image _Image;
        protected ImageObject(Point Position, Point Direction, Size Size, Image Image)
            : base(Position, Direction, Size)
        {
            _Image = Image;
        }
        public override void Draw(Graphics g)
        {
            g.DrawImage(_Image, _Position.X, _Position.Y, _Size.Width, _Size.Height);
        }
    }

    internal class SunStar : ImageObject
    {
        public SunStar(Point Position, int ImageSize)
    : base(Position, Point.Empty, new Size(ImageSize, ImageSize), Properties.Resources.SunStar)
        {
        }
    }
}
