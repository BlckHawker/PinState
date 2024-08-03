using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
    internal class None : IPinState
    {
        public None()
        { 
            
        }
        public int GetScore()
        {
            return int.MinValue;
        }

        public string GetFirstThrow()
        {
            return "-";
        }

        public string GetSecondThrow()
        {
            return "-";
        }
    }
}
