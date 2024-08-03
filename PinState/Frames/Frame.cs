using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using PinState.States;
using States;

namespace PinState.Frames
{
    internal abstract class Frame
    {
        protected IPinState pinState;
        protected int[] pinsKnockedDown;
        protected Frame previousFrame;
        protected Frame nextFrame;
        public Frame(Frame previousFrame)
        {
            this.previousFrame = previousFrame;
            pinState = new None();
            pinsKnockedDown = new int[3];
        }


        public abstract void setNext(Frame next);

        public abstract void SetFirstThrowPins(int pins);

        public abstract void SetSecondThrowPins(int pins);

        public abstract int GetPinsKnockedDown();

        public abstract int GetScore();

        public abstract string GetFirstThrow();

        public abstract string GetSecondThrow();

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

        public static bool IsOpen(Frame frame)
        {
            return frame != null && frame.pinState is Open;
        }

        public static bool IsClosed(Frame frame)
        {
            return frame != null && frame.pinState is Closed;
        }

        public IPinState GetPinState()
        {
            return pinState;
        }

        public Frame GetPreviousFrame()
        { 
            return previousFrame;
        }

        protected void SetState(IPinState pinState)
        {
            this.pinState = pinState;
        }

        

        public override abstract string ToString();
    }
}
