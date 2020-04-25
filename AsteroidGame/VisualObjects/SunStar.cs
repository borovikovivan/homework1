using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidGame.VisualObjects

{   //создали абстрактный класс для изображений и от него наследуем класс солнце для отрисовки солнца


    internal class SunStar : ImageObject
    {
        public SunStar(Point Position, int ImageSize)
            : base(Position, Point.Empty, new Size(ImageSize, ImageSize), Properties.Resources.Sun)
        {
        }
    }
    
}
