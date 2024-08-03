using States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PinState.States
{
    internal class Strike : IPinState
    {
        //keeps track of the next two frames
        Frame[] nextFrames;
        

        public Strike()
        {
            nextFrames = new Frame[] { null, null };
        }
        public string GetFirstThrow()
        {
            return "X";
        }

        public int GetScore()
        {
            //if both frames don't exist, return zero
            if (nextFrames.All(x => x == null))
            {
                return 0;
            }

            //if both frames ahead are strikes, return 30
            if (nextFrames.All(x => Frame.IsStrike(x)))
            {
                return 30;
            }
            //if the firsrt frame is null, then return zero
            if (nextFrames[0] == null)
            {
                return 0;
            }

            


            //if first frame is a strike, but the frame doesn't exist, return zero
            if (Frame.IsStrike(nextFrames[0]) && nextFrames[1] == null)
            {
                return 0;
            }

            //if first throw is a stirke, and the second one is not null, return 20 plus the first roll in the second frame
            else if (Frame.IsStrike(nextFrames[0]) && !Frame.IsStrike(nextFrames[1]))
            {
                return 20 + int.Parse(nextFrames[1].GetFirstThrow());
            }


            //if the first frame is not closed, return the score + 10
            else if (Frame.IsClosed(nextFrames[0]))
            {
                return 10 + CalculateClosedFrameScore(nextFrames[0]);
            }
            else
            {
                Console.WriteLine("Undocumenated condition");
                return 0;
            }
        }

        public string GetSecondThrow()
        {
            return "-";
        }

        public void setFirstFrame(Frame frame)
        {
            nextFrames[0] = frame;
        }

        public void setSecondFrame(Frame frame)
        {
            nextFrames[1] = frame;
        }

        public Frame[] getNextFrames()
        { 
            return nextFrames;
        }

        private int CalculateClosedFrameScore(Frame frame)
        {
            //if the next frame is open, return zero
            if (Frame.IsOpen(frame))
            {
                return 0;
            }

            int[] sum = new int[2];
            sum[0] = int.Parse(frame.GetFirstThrow());

            //if spare, do some math in order to get the second number
            if (Frame.IsSpare(frame))
            {
                sum[1] = 10 - sum[0];
            }


            else
            {
                sum[1] = int.Parse(frame.GetSecondThrow());
            }

            return sum.Sum();
        }
    }
}
