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
            ThrowCount acutalThrow = currentFrame.GetThrow() - 1;
            if (acutalThrow == ThrowCount.First)
            {
                return "";
            }

            //second throw could be spare, strike or number

            //spare
            if (pinsKnockedDown[0] != 10 && pinsKnockedDown[0] + pinsKnockedDown[1] == 10)
            {
                return "/";
            }

            //strike
            if (pinsKnockedDown[1] == 10)
            {
                return "X";
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

            //third throw could be spare, strike or number

            //spare
            if (pinsKnockedDown[1] != 10 && pinsKnockedDown[1] + pinsKnockedDown[2] == 10)
            {
                return "/";
            }

            //strike
            if (pinsKnockedDown[2] == 10)
            {
                return "X";
            }

            //number
            return "" + pinsKnockedDown[2];


        }

        public int GetScore()
        {
            
            string firstThrow = GetFirstThrow();
            string secondThrow = GetSecondThrow();
            string thirdThrow = GetThirdThrow();

            int[] throwNums = new int[] { int.MinValue, int.MinValue, int.MinValue };
            bool[] isNumber = new bool[] { int.TryParse(firstThrow, out throwNums[0]), int.TryParse(secondThrow, out throwNums[1]), int.TryParse(thirdThrow, out throwNums[2]) };



            ThrowCount throwCount = currentFrame.GetThrow();
            //don't calculate if a strike or spare has gottan and the third thrown has been done
            if (((firstThrow == "X" || secondThrow == "/" || secondThrow == "X") && currentFrame.GetThrow() == ThrowCount.Second) || currentFrame.GetThrow() != ThrowCount.Third)
            { 
                return 0;
            }
            //if they were all strikes, return 30
            if (firstThrow == "X" && secondThrow == "X" && thirdThrow == "X")
            {
                return 30;
            }

            //if the first throw a strike, and the other two were numbers, return 10 + other two numbers
            if (firstThrow == "X" && isNumber[1] && isNumber[2])
            { 
                return 10 + throwNums[1] + throwNums[2];
            }

            //if all three throws are numbers, then sum them up
            if (isNumber.All(x => x))
            {
                return throwNums.Sum();
            }

            //if the first two throws were strikes, and the last one wasn't, return 20 + last number
            if (firstThrow == "X" && secondThrow == "X" && thirdThrow != "X")
            {
                return 20 + throwNums[2];
            }

            //if the second throw led to a spare, and the last throw was a not a strike, return 10 + last number
            if (secondThrow == "/" && thirdThrow != "X")
            {
                return 10 + throwNums[2];
            }

            //if the second throw led to a spare, and the last throw was a strike, add 20
            if (secondThrow == "/" && thirdThrow == "X")
            {
                return 20;
            }


            throw new Exception("This should not happen");
        }

    }
}
