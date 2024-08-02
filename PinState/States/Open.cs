using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
    internal class Open : IPinState
    {
        int firstPinsKnockedDown;
        public Open(int pins) 
        {
            firstPinsKnockedDown = pins;
        }
        public int GetScore()
        {
            throw new NotImplementedException();
        }
    }
}
