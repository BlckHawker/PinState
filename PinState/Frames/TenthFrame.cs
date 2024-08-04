using PinState.States;
using States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinState.Frames
{
    internal class TenthFrame : Frame
    {
        private ThrowCount throwCount;

        public TenthFrame(Frame previousFrame) : base(previousFrame) 
        {
            pinState = new TenthState(this);
            throwCount = ThrowCount.First;
        }

        public ThrowCount GetThrow()
        {
            return throwCount;
        }

        public override void setNext(Frame next)
        {
            nextFrame = next;
        }

        public override void SetFirstThrowPins(int pins)
        {
            pinsKnockedDown[0] = pins;
            throwCount++;
        }

        public override void SetSecondThrowPins(int pins)
        {
            pinsKnockedDown[1] = pins;
            throwCount++;
        }

        public int[] GetPinsKnockedDownArr()
        {
            return pinsKnockedDown;
        }

        public void SetThirdThrowPins(int pins)
        {
            pinsKnockedDown[2] = pins;
        }

        public override int GetScore()
        {
            return pinState.GetScore();
        }

        public override int GetPinsKnockedDown()
        {
            return pinsKnockedDown.Sum();
        }

        public override string GetFirstThrow()
        {
            return pinState.GetFirstThrow();
        }

        public override string GetSecondThrow()
        {
            return pinState.GetSecondThrow();
        }

        public override string ToString()
        {
            string s = $"First throw: {pinState.GetFirstThrow()}\n";
            s += $"Second throw: {pinState.GetSecondThrow()}\n";
            s += $"Third throw: {((TenthState)pinState).GetThirdThrow()}\n";
            s += $"Score: {pinState.GetScore()}\n";
            return s;
        }

    }
}
