using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class Rover
    {
        private readonly Plateau _plateau;

        private readonly List<Position> _movements;

        public Rover(string name, Plateau plateau, Position position)
        {
            _plateau = plateau;
            _movements = new List<Position>();
            Name = name;
            Apply(position);
        }

        public string Name { get; private set; }

        public Position Position { get; private set; }

        public IEnumerable<Position> Movements
        {
            get { return _movements; }
        }

        public void Move()
        {
            Apply(Position.Move());
        }

        public void Left()
        {
            Apply(Position.Left());
        }

        public void Right()
        {
            Apply(Position.Right());
        }

        private void Apply(Position position)
        {
            if (!_plateau.Contains(position))
            {
                return;
            }
            _movements.Add(position);
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Position);
        }
    }
}
