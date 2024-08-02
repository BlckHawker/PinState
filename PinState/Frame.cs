using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using States;

namespace PinState
{
    internal class Frame
    {
        private IPinState pinState;
        private int[] pinsKnockedOut;
        private Frame prevoiusFrame;
        public Frame(Frame prevoiusFrame) 
        {
            this.prevoiusFrame = prevoiusFrame;
            pinState = new None();
            pinsKnockedOut = new int[2];
        }
        public void SetFirstThrowPins(int pins)
        {
            pinsKnockedOut[0] = pins;
            if (pins == 10)
            {
                //Set Strike
            }

            else
            {
                SetState(new Open(pinsKnockedOut[0]));
            }    
        }
        public void SetSecondThrowPins(int pins)
        {
            pinsKnockedOut[1] += pins;
            int pinSum = pinsKnockedOut.Sum();
            if (pinSum == 10)
            {
                //Set Spare
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
            return $"First throw: {pinsKnockedOut[0]}\nSecond throw: {pinsKnockedOut[1]}\nScore: {GetScore()}";
        }

        public int GetScore()
        {
            int previousScore = 0;
            if(prevoiusFrame != null)
            {
                previousScore = prevoiusFrame.GetScore();
            }
            return previousScore + pinState.GetScore();
        }

        public int GetPinsKnockedDown()
        {
            return pinsKnockedOut.Sum();
        }
    }
}
