using PinState.States;
using States;
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
            Frame currentFrame = frames[0];
            int counter = 0;

            do
            {
                counter++;
                if (counter == 10)
                {
                    break;
                }

                if (Frame.IsStrike(currentFrame))
                {
                    int i = 0;
                }
                s += $"Frame {counter}\n{currentFrame.ToString()}\n\n";
                currentFrame = frames[counter];
            } while (!Frame.IsNone(currentFrame) || counter == 10);
            s += $"Current Score: {GetScore()}\n==============================================";
            return s;
        }

        public void Throw(int pins)
        {
            Frame currentFrame = frames[currentFrameIndex];

            //check if this is the first throw or second
            bool firstThrow = Frame.IsNone(currentFrame);

            if (firstThrow)
            {
                currentFrame.SetFirstThrowPins(pins);
                if (currentFrame.GetPinsKnockedDown() == 10)
                {
                    currentFrameIndex++;
                }
            }

            else
            {
                currentFrame.SetSecondThrowPins(pins);

                if (currentFrameIndex != 9)
                {
                    currentFrameIndex++;
                }
            }
        }
        public int GetScore()
        { 
            int score = 0;
            for (int i = 0; i < currentFrameIndex; i++)
            {
                if (!Frame.IsSpare(frames[currentFrameIndex]))
                { 
                    score += frames[i].GetScore();
                }
            }

            return score;
        }


    }
}
