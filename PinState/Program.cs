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
        
        
        //===============do on saturday
        //strike is first frame

        //spare is first frame

        //method that gets input from user
    }
}
