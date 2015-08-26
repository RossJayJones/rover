using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class Position
    {
        private Position()
        {

        }

        public Position(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public Direction Direction { get; private set; }

        public Position Left()
        {
            var position = new Position
            {
                X = X,

                Y = Y,

                Direction = Turn(-90)
            };
            return position;
        }

        public Position Right()
        {
            var position = new Position
                {
                    X = X,

                    Y = Y,

                    Direction = Turn(90)
                };

            return position;
        }

        public Position Move()
        {
            var position = new Position
            {
                Direction = Direction,
                
                Y = new Func<int>(() => {

                    if (Direction == Direction.N)
                    {
                        return Y + 1;
                    }

                    if (Direction == Direction.S)
                    {
                        return Y - 1;
                    }

                    return Y;
                })(),

                X = new Func<int>(() =>
                {
                    if (Direction == Direction.E)
                    {
                        return X + 1;
                    }

                    if (Direction == Direction.W)
                    {
                        return X - 1;
                    }

                    return X;
                })()
            };

            return position;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", X, Y, Direction);
        }

        private Direction Turn(int amount)
        {
            return (Direction)Abs(((int)Direction + amount));
        }

        private int Abs(int value)
        {
            if (value == 360)
            {
                return 0;
            }

            if (value < 0)
            {
                return value + 360;
            }

            return value;
        }
    }
}
