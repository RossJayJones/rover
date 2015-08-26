using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class DefaultInstructionDispatcher : IInstructionDispatcher
    {
        private const char Right = 'R';

        private const char Left = 'L';

        private const char Move = 'M';

        public void Dispatch(Rover rover, string instructions)
        {
            foreach (var instruction in instructions)
            {
                if (instruction == Move)
                {
                    rover.Move();
                }
                else if (instruction == Left)
                {
                    rover.Left();
                }
                else if (instruction == Right)
                {
                    rover.Right();
                }
            }
        }
    }
}
