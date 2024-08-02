using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
    internal class Closed : IPinState
    {
        int[] pins = new int[2];

        public Closed(int first, int second) 
        {
            pins[0] = first;
            pins[1] = second;
        }

        public int GetScore()
        {
            return pins.Sum();
        }
    }
}
