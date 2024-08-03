using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using PinState.States;
using States;

namespace PinState
{
    internal class Frame
    {
        private IPinState pinState;
        private int[] pinsKnockedOut;
        Frame previousFrame;
        Frame nextFrame;
        public Frame(Frame previousFrame)
        {
            this.previousFrame = previousFrame;
            pinState = new None();
            pinsKnockedOut = new int[2];
        }

        public void setNext(Frame next)
        {
            nextFrame = next;
        }
        public void SetFirstThrowPins(int pins)
        {
            //if the previous frame is a spare, set the next throw
            if (IsSpare(previousFrame))
            {
                ((Spare)previousFrame.pinState).SetNextThrow(pins);
            }

            //if the previous frame is a spare, set the first frame
            else if(IsStrike(previousFrame))
            { 
                ((Strike)previousFrame.pinState).setFirstFrame(this);

                //if two frames from this one was a strike, set the second frame
                if (IsStrike(previousFrame.previousFrame))
                { 
                    ((Strike)previousFrame.previousFrame.pinState).setSecondFrame(this);
                }
            }

            pinsKnockedOut[0] = pins;

            if (pins == 10)
            {
                SetState(new Strike());
            }

            else
            { 
                SetState(new Open(pinsKnockedOut[0]));
            }
        }
        public void SetSecondThrowPins(int pins)
        {
            pinsKnockedOut[1] = pins;
            int pinSum = pinsKnockedOut.Sum();

            

            if (pinSum == 10)
            {
                SetState(new Spare(pinsKnockedOut[0], pinsKnockedOut[1]));
            }
            else
            { 
                SetState(new Closed(pinsKnockedOut[0], pinsKnockedOut[1]));
            }

            // the prevois strike's first frame to this
            if (IsStrike(previousFrame))
            {
                Strike strike = (Strike)previousFrame.pinState;
                strike.setFirstFrame(this);

                //if two frames from this one was a strike,set the second frame
                if (IsStrike(previousFrame.previousFrame))
                {
                    Strike strike2 = (Strike)previousFrame.previousFrame.pinState;
                    strike2.setSecondFrame(this);
                }
            }
        }

        private void SetState(IPinState pinState) 
        {
            this.pinState = pinState;
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

        public int GetScore()
        {
            return pinState.GetScore();
        }

        public int GetPinsKnockedDown()
        {
            return pinsKnockedOut.Sum();
        }

        public string GetFirstThrow()
        {
            return pinState.GetFirstThrow();
        }

        public string GetSecondThrow()
        {
            return pinState.GetSecondThrow();
        }

        public static bool IsStrike(Frame frame)
        {
            return frame != null && frame.pinState is Strike;
        }

        public static bool IsSpare(Frame frame)
        {
            return frame != null && frame.pinState is Spare;
        }

        public static bool IsNone(Frame frame)
        {
            return frame != null && frame.pinState is None;
        }
    }
}
