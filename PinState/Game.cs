using PinState.Frames;
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
                
                Frame newFrame = i != 9 ? new RegularFrame(previous) : new TenthFrame(previous);
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
                if (counter == 10)
                {
                    break;
                }
                currentFrame = frames[counter];

                s += $"Frame {counter + 1}\n{currentFrame.ToString()}\n\n";
                counter++;

            } while (counter == 10 || !Frame.IsNone(frames[counter]));
            s += $"Current Score: {GetScore()}\n==============================================";

            return s;
        }

        public void Throw(int pins)
        {
            Frame currentFrame = frames[currentFrameIndex];

            //check if this is the first throw or second
            bool regularFrame = currentFrame is RegularFrame;
            bool firstThrow = (regularFrame && Frame.IsNone(currentFrame)) || (!regularFrame && ((TenthFrame)currentFrame).GetThrow() == ThrowCount.First);
            Console.WriteLine(regularFrame);
            if (regularFrame)
            {
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
                    currentFrameIndex++;
                    Console.WriteLine("Current index: " + currentFrameIndex);
                }
            }

            else
            {
                TenthFrame tenthFrame = (TenthFrame)currentFrame;
                if (firstThrow)
                {
                    tenthFrame.SetFirstThrowPins(pins);
                }

                else if (tenthFrame.GetThrow() == ThrowCount.Second)
                {
                    tenthFrame.SetSecondThrowPins(pins);
                }

                else
                {
                    tenthFrame.SetThirdThrowPins(pins);
                }
            }

        }
        public int GetScore()
        { 
            int score = 0;
            for (int i = 0; i < currentFrameIndex; i++)
            {
                score += frames[i].GetScore();
            }

            if (currentFrameIndex == 9)
            {
                score += frames.Last().GetScore();
            }

            return score;
        }

        public bool isDone()
        {
            Frame lastFrame = frames.Last();

            return !Frame.IsNone(lastFrame) && !Frame.IsOpen(lastFrame);
        }


    }
}
