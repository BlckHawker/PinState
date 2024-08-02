using States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinState.States
{
    internal class Spare : IPinState
    {
        int[] pins = new int[2];
        int nextThrow;
        public Spare(int first, int second, int nextThrow = int.MinValue) 
        {
            pins[0] = first;
            pins[1] = second;
            this.nextThrow = nextThrow;
        }

        public void SetNextThrow(int nextThrow)
        {
            this.nextThrow = nextThrow;
        }

        public int GetNextThrow()
        {
            return nextThrow;
        }

        public int GetScore()
        {
            return nextThrow == int.MinValue ? 0 : nextThrow + 10;
        }
    }
}
