namespace PinState
{
    internal class Program
    {
        static void Main(string[] args)
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

    }
}
