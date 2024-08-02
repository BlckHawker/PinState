using PinState.States;
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
                Frame previous = i == 0 ? null : frames[i - 1];
                Frame newFrame = new Frame(previous);
                frames.Add(newFrame);
            }

            for (int i = 0; i < 10; i++)
            {
                Frame next = i == 9 ? null : frames[i + 1];
                Frame newFrame = frames[i];
                newFrame.setNext(next);
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < currentFrameIndex; i++)
            {
                s += $"Frame {i+1}\n{frames[i].ToString()}\n\n";
            }
            s += $"Current Score: {GetScore()}\n==============================================";
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

        public int GetScore()
        { 
            int score = 0;
            for (int i = 0; i < currentFrameIndex; i++)
            {
                if (frames[currentFrameIndex].GetPinsState() is not Spare)
                { 
                    score += frames[i].GetScore();
                }
            }

            return score;
        }


    }
}
