namespace PinState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrikeSpareSomething();
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
        public static void StrikeTurkeySomething()
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

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

        }

        //spare, strike, nothing
        public static void SpareStrikeNothing()
        { 
            Game game = new Game();
            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(5);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);
        }

        //spare, strike, something
        public static void SpareStrikeSomething()
        {
            Game game = new Game();
            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(5);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);
        }

        //strike, spare, nothing
        public static void StrikeSpareNothing()
        {
            Game game = new Game();
            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

            game.SetFirstThrowPins(5);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);
        }

        //strike, spare, something
        public static void StrikeSpareSomething()
        {
            Game game = new Game();
            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);

            game.SetFirstThrowPins(10);
            Console.WriteLine(game);

            game.SetFirstThrowPins(5);
            game.SetSecondThrowPins(5);
            Console.WriteLine(game);

            game.SetFirstThrowPins(1);
            game.SetSecondThrowPins(1);
            Console.WriteLine(game);
        }
        //===============do on saturday
        //strike is first frame

        //spare is first frame
    }
}
