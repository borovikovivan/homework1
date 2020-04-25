using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AsteroidGame.VisualObjects
{
    internal class SpaceShip : ImageObject
    {
        public SpaceShip(Point Position, Point Direction, int ImageSize)
            : base(Position, Direction, new Size(ImageSize, ImageSize), Properties.Resources.Ship)
        {
        }
        public override void Update()
        {
            _Position = new Point(_Position.X + 3, _Position.Y);
        }
    }
}
