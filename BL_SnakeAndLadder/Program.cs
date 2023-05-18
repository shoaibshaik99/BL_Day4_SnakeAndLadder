namespace BL_SnakeAndLadder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder Game\n");
            int plrPos = 0; // Player Position
            Console.WriteLine("Initial position of player is " + plrPos);
            int diceRoll; // Dice rolling
            Random random = new Random();
            diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice rolled: "+diceRoll);
        }
    }
}