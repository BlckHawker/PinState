using System.Runtime.CompilerServices;

namespace PinState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TenthFrameRegular();
        }

        public static void NonSpecialGame()
        {
            Game game = new Game();

            game.Throw(6);
            game.Throw(1);

            game.Throw(7);
            game.Throw(0);

            game.Throw(0);
            game.Throw(8);

            game.Throw(9);
            game.Throw(0);

            game.Throw(2);
            game.Throw(0);

            game.Throw(7);
            game.Throw(1);

            game.Throw(9);
            game.Throw(0);

            game.Throw(6);
            game.Throw(3);

            game.Throw(0);
            game.Throw(5);

            game.Throw(1);
            game.Throw(6);

            Console.WriteLine(game);
        }

        public static void HalwaySpareGame()
        {
            Game game = new Game();

            game.Throw(2);
            game.Throw(5);
            Console.WriteLine(game);


            game.Throw(3);
            game.Throw(5);
            Console.WriteLine(game);

            game.Throw(2);
            game.Throw(5);
            Console.WriteLine(game);

            game.Throw(2);
            game.Throw(6);
            Console.WriteLine(game);

            game.Throw(5);
            game.Throw(5);
            Console.WriteLine(game);
        }

        public static void SpareGame()
        {
            Game game = new Game();

            game.Throw(2);
            game.Throw(5);
            Console.WriteLine(game);


            game.Throw(3);
            game.Throw(5);
            Console.WriteLine(game);

            game.Throw(2);
            game.Throw(5);
            Console.WriteLine(game);

            game.Throw(2);
            game.Throw(6);
            Console.WriteLine(game);

            game.Throw(5);
            game.Throw(5);
            Console.WriteLine(game);

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(1);
            game.Throw(9);
            Console.WriteLine(game);

            game.Throw(1);
            game.Throw(9);
            Console.WriteLine(game);

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);
        }


        //teat strike single with next frame being empty
        public static void StrikeSingleEmpty()
        {
            Game game = new Game();

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);
        }

        //test stirke single with next frame not being empty
        public static void StrikeSingle()
        {
            Game game = new Game();

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);
        }

        public static void StrikeDoubleEmpty()
        {
            Game game = new Game();

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);
        }

        public static void StrikeDouble()
        {
            Game game = new Game();

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);
        }

        public static void StrikeTurkeyEmpty()
        {
            Game game = new Game();

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

        }

        //turkey, something
        public static void StrikeTurkeySomething()
        {
            Game game = new Game();

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

        }

        //spare, strike, nothing
        public static void SpareStrikeNothing()
        { 
            Game game = new Game();
            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(5);
            game.Throw(5);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);
        }

        //spare, strike, something
        public static void SpareStrikeSomething()
        {
            Game game = new Game();
            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(5);
            game.Throw(5);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);
        }

        //strike, spare, nothing
        public static void StrikeSpareNothing()
        {
            Game game = new Game();
            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(5);
            game.Throw(5);
            Console.WriteLine(game);
        }

        //strike, spare, something
        public static void StrikeSpareSomething()
        {
            Game game = new Game();
            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

            game.Throw(10);
            Console.WriteLine(game);

            game.Throw(5);
            game.Throw(5);
            Console.WriteLine(game);

            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);
        }

        //strike is first frame
        public static void StrikeFirst()
        { 
            Game game = new Game();
            game.Throw(10);
            game.Throw(10);
            game.Throw(10);
            Console.WriteLine(game);

        }
        //spare is first frame
        public static void SpareFirst()
        {
            Game game = new Game();
            game.Throw(5);
            game.Throw(5);
            game.Throw(1);
            game.Throw(1);
            Console.WriteLine(game);

        }

        public static void Debug()
        {
            Game game = new Game();

            //Frame 1
            game.Throw(8);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 2
            game.Throw(7);
            Console.WriteLine(game);
            game.Throw(2);
            Console.WriteLine(game);

            //Frame 3
            game.Throw(7);
            Console.WriteLine(game);
            game.Throw(2);
            Console.WriteLine(game);

            //Frame 4
            game.Throw(7);
            Console.WriteLine(game);
            game.Throw(3);
            Console.WriteLine(game);

            //Frame 5
            game.Throw(8);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 6
            game.Throw(8);
            Console.WriteLine(game);
            game.Throw(2);
            Console.WriteLine(game);

            //Frame 7
            game.Throw(9);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 8
            game.Throw(10);
            Console.WriteLine(game);

            //Frame 9
            game.Throw(7);
            Console.WriteLine(game);
            game.Throw(2);
            Console.WriteLine(game);

            //Frame 10
            //game.Throw(9);
            //Console.WriteLine(game);
            //game.Throw(0);
            //Console.WriteLine(game);
        }


        public static void TenthFrameRegular()
        {
            Game game = new Game();

            //Frame 1
            game.Throw(1);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 2
            game.Throw(1);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 3
            game.Throw(1);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 4
            game.Throw(1);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 5
            game.Throw(1);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 6
            game.Throw(1);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 7
            game.Throw(1);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 8
            game.Throw(1);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);

            //Frame 9
            game.Throw(1);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);


            //Frame 10
            game.Throw(10);
            Console.WriteLine(game);
            game.Throw(1);
            Console.WriteLine(game);
        }

        //method that gets input from user
        public static void InputGame()
        {
            string input;
            int inputNum;
            Game game = new Game();

            do
            {
                do
                {
                    Console.Write("Input: ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out inputNum));

                game.Throw(inputNum);
                Console.WriteLine(game);
            } while (!game.isDone());

            Console.WriteLine(game);
        }
    }
}
