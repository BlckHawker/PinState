using PinState.States;
using States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinState.Frames
{
    internal class RegularFrame : Frame
    {

        public RegularFrame(Frame previousFrame) : base(previousFrame) { }

        public override void setNext(Frame next)
        {
            nextFrame = next;
        }
        public override void SetFirstThrowPins(int pins)
        {
            //if the previous frame is a spare, set the next throw
            if (IsSpare(previousFrame))
            {
                ((Spare)previousFrame.GetPinState()).SetNextThrow(pins);

                this.GetPinState();
            }

            //if the previous frame is a spare, set the first frame
            else if (IsStrike(previousFrame))
            {
                ((Strike)previousFrame.GetPinState()).setFirstFrame(this);

                //if two frames from this one was a strike, set the second frame
                if (IsStrike(previousFrame.GetPreviousFrame()))
                {
                    ((Strike)previousFrame.GetPreviousFrame().GetPinState()).setSecondFrame(this);
                }
            }

            pinsKnockedDown[0] = pins;

            if (pins == 10)
            {
                SetState(new Strike());
            }

            else
            {
                SetState(new Open(pinsKnockedDown[0]));
            }
        }
        public override void SetSecondThrowPins(int pins)
        {
            pinsKnockedDown[1] = pins;
            int pinSum = pinsKnockedDown.Sum();



            if (pinSum == 10)
            {
                SetState(new Spare(pinsKnockedDown[0], pinsKnockedDown[1]));
            }
            else
            {
                SetState(new Closed(pinsKnockedDown[0], pinsKnockedDown[1]));
            }

            // the prevois strike's first frame to this
            if (IsStrike(previousFrame))
            {
                Strike strike = (Strike)previousFrame.GetPinState();
                strike.setFirstFrame(this);

                //if two frames from this one was a strike,set the second frame
                if (IsStrike(previousFrame.GetPreviousFrame()))
                {
                    Strike strike2 = (Strike)previousFrame.GetPreviousFrame().GetPinState();
                    strike2.setSecondFrame(this);
                }
            }
        }

        public override string ToString()
        {
            string s = $"First throw: {pinState.GetFirstThrow()}\n";
            if (pinState is not Strike)
            {
                s += $"Second throw: {pinState.GetSecondThrow()}\n";
            }

            s += $"Score: {pinState.GetScore()}\n";
            return s;
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
    }
}
