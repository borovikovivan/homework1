using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidGame
{
    internal class Ship : VisualObject

    {
        public Ship (Point Position, Point Direction, int Size)
         : base(Position, Direction, new Size(Size, Size))
        {

        }
    }
}
