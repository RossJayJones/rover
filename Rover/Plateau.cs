using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class Plateau
    {
        public Plateau(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public bool Contains(Position position)
        {
            if (position.X > Width)
            {
                return false;
            }

            if (position.Y > Height)
            {
                return false;
            }

            if (position.X < 0)
            {
                return false;
            }

            if (position.Y < 0)
            {
                return false;
            }

            return true;
        }
    }
}
