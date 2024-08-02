using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinState
{
    internal class Game
    {
        List<Frame> frames;
        int currentFrameIndex;

        public Game()
        {
            currentFrameIndex = 0;
            frames = new List<Frame>();
            for (int i = 0; i < 10; i++)
            {
                Frame previousFrame =  i == 0 ? null : frames[i - 1];
                frames.Add(new Frame(previousFrame));
            }

        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < 10; i++)
            {
                s += $"Frame {i+1}\n{frames[i].ToString()}\n\n";
            }
            return s;
        }

        public void SetFirstThrowPins(int pins)
        {
            Frame frame = frames[currentFrameIndex];
            frame.SetFirstThrowPins(pins);
            if (frame.GetPinsKnockedDown() == 10)
            {
                currentFrameIndex++;
            }

        }

        public void SetSecondThrowPins(int pins)
        {
            Frame frame = frames[currentFrameIndex];
            frame.SetSecondThrowPins(pins);
            currentFrameIndex++;
        }


    }
}
