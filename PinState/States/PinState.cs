﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
    public interface IPinState
    {
        public int GetScore();

        public string GetFirstThrow();

        public string GetSecondThrow();

    }
}
