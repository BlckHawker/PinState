namespace PinState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrikeTurkeyEmpty();
        }

        public static void NonSpecialGame()
        {
            Game game = new Game();

            game.SetFirstThrowPins(6);
            game.SetSecondThrowPins(1);

            game.SetFirstThrowPins(7);
            game.SetSecondThrowPins(0);

            game.SetFirstThrowPins(0);
            game.SetSecondThrowPins(8);

            game.SetFirstThrowPins(9);
            game.SetSecondThrowPins(0);

            game.SetFirstThrowPins(2);
            game.SetSecondThrowPins(0);

            game.SetFirstThrowPins(7);
            game.SetSecondThrowPins(1);

            game.SetFirstThrowPins(9);
            game.SetSecondThrowPins(0);

            game.SetFirstThrowPins(6);
            game.SetSecondThrowPins(3);

            game.SetFirstThrowPins(0);
            game.SetSecondThrowPins(5);

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(6);

            Console.WriteLine(game);
        }

        public static void HalwaySpareGame()
        {
            Game game = new Game();

            game.SetFirstThrowPins(2);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);


            game.SetFirstThrowPins(3);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);

            game.SetFirstThrowPins(2);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);

            game.SetFirstThrowPins(2);
            game.SetSecondThrowPins(6);
            Console.WriteLine(game);

            game.SetFirstThrowPins(5);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);
        }

        public static void SpareGame()
        {
            Game game = new Game();

            game.SetFirstThrowPins(2);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);


            game.SetFirstThrowPins(3);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);

            game.SetFirstThrowPins(2);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);

            game.SetFirstThrowPins(2);
            game.SetSecondThrowPins(6);
            Console.WriteLine(game);

            game.SetFirstThrowPins(5);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(9);
            Console.WriteLine(game);

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(9);
            Console.WriteLine(game);

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);
        }


        //teat strike single with next frame being empty
        public static void StrikeSingleEmpty()
        {
            Game game = new Game();

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);
        }

        //test stirke single with next frame not being empty
        public static void StrikeSingle()
        {
            Game game = new Game();

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);
        }

        //tests double with both next frames being emoty
        public static void StrikeDoubleEmpty()
        {
            Game game = new Game();

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);
        }

        public static void StrikeDouble()
        {
            Game game = new Game();

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);
        }

        public static void StrikeTurkeyEmpty()
        {
            Game game = new Game();

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

        }

        //turkey, something

        //spare, strike, nothing

        //spare, strike, something


        //strike, spare, nothing

        //strike, spare, something




    }
}
