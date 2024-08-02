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
            if (previousFrame != null && previousFrame.pinState is Spare)
            { 
                ((Spare)previousFrame.pinState).SetNextThrow(pins);
            }
            pinsKnockedOut[0] = pins;
            SetState(new Open(pinsKnockedOut[0]));
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

        }

        private void SetState(IPinState pinState) 
        {
            this.pinState = pinState;
        }

        public override string ToString()
        {
            string s = $"First throw: {pinsKnockedOut[0]}";

           
            if (pinState is Spare)
            {
                s += "\nSecond throw: /";
                //current frame is a spare and next frame does not exist
                if (nextFrame.pinState is None)
                {
                   s += "\nScore: -";
                }

                //current frame is a spare and next frame does exist
                else
                {
                    int bonus = nextFrame.GetPinsKnockedDown();
                    s += $"\nScore: {10 + bonus}";
                }
            }

            else //Closed
            {
                s += $"\nSecond throw: {pinsKnockedOut[1]}\nScore: {GetScore()}";
            }
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

        //! This needs to change as the purpose of the context is to have the state been encapsualted and not seen by any other outside method
        public IPinState GetPinsState()
        { 
            return this.pinState;
        }
    }
}
