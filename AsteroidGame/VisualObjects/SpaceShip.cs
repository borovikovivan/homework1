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
            _Position.X += _Direction.X;

            if (_Position.X < 0)
                _Position.X = Game.Width + _Size.Width;

            _Position.Y += _Direction.Y;

            if (_Position.Y < 0)
                _Position.Y = Game.Height - _Size.Height;

            //_Position = new Point(_Position.X, _Position.Y);
            //_Direction = new Point(_Direction.X, _Direction.Y);
        }
    }
}
