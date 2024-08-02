namespace PinState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpareGame();
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
    }
}
