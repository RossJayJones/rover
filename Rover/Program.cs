using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            var plateau = new Plateau(5, 5);

            var dispatcher = new DefaultInstructionDispatcher();

            var rover1 = new Rover("Rover 1", plateau, new Position(1, 2, Direction.N));

            dispatcher.Dispatch(rover1, "LMLMLMLMM");

            var rover2 = new Rover("Rover 2", plateau, new Position(3, 3, Direction.E));

            dispatcher.Dispatch(rover2, "MMRMMRMRRM");

            Clear();

            Print(plateau);

            Print(rover1);

            Clear();

            //Print(plateau);

            //Print(rover2);

            Console.WriteLine(rover1);

            Console.WriteLine(rover2);

            Console.ReadLine();
        }

        static void Clear()
        {
            Console.Clear();
        }

        static void Print(Plateau plateau)
        {
            for (int i = 0; i <= plateau.Width; i++)
            {
                for (int j = 0; j <= plateau.Height; j++)
                {
                    Console.SetCursorPosition(i, j);

                    Console.Write("#");
                }
            }
        }

        static void Print(Rover rover)
        {
            foreach (var item in rover.Movements)
            {
                Console.SetCursorPosition(item.X, item.Y);

                Console.Write("X");
            }
        }
    }
}
