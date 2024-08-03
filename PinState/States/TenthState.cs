using PinState.Frames;
using States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinState.States
{
    internal class TenthState : IPinState
    {
        TenthFrame currentFrame;
        int[] pinsKnockedDown;

        public TenthState(TenthFrame currentFrame)
        { 
            this.currentFrame = currentFrame;
            this.pinsKnockedDown = currentFrame.GetPinsKnockedDownArr();
        }


      

        public string GetFirstThrow()
        {
            //is strike
            if (pinsKnockedDown[0] == 10)
            {
                return "X";
            }

            //it's a number
            return "" + pinsKnockedDown[0];

        }

        public string GetSecondThrow()
        {
            if (currentFrame.GetThrow() == ThrowCount.First)
            {
                return "";
            }

            //second throw could be spare, strike or number
            if (pinsKnockedDown[1] == 10)
            {
                return "X";
            }

            //spare
            if (pinsKnockedDown[0] != 10 &&  pinsKnockedDown[0] + pinsKnockedDown[1] == 10)
            {
                return "/";
            }

            //number
            return "" + pinsKnockedDown[1];
        }

        public string GetThirdThrow()
        {
            if (currentFrame.GetThrow() != ThrowCount.Third)
            {
                return "";
            }

            throw new NotImplementedException();
        }

        public int GetScore()
        {
            return 0;
        }
    }
}
