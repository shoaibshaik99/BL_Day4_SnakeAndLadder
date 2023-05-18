namespace BL_SnakeAndLadder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            const int MIN_POS = 0;
            const int MAX_POS = 100;
            Console.WriteLine("Welcome to Snake & Ladder Game\n");
            int plrPos = 0; // Player Position
            //Console.WriteLine("Initial position of player is " + plrPos + "\n");
            int diceRoll; // Dice rolling
            Random random = new Random();
            while (plrPos< MAX_POS)
            {
                diceRoll = random.Next(1, 7);
                Console.WriteLine("Dice rolled: " + diceRoll);
                int option = random.Next(0, 3);//0,1,2
                switch (option)
                {
                    case NO_PLAY:
                        Console.WriteLine("For this dice roll the move is  No Play");
                        break;
                    case LADDER:
                        Console.WriteLine("For this dice roll the move is  Ladder");
                        plrPos += diceRoll;
                        break;
                    case SNAKE:
                        Console.WriteLine("For this dice roll the move is  Snake");
                        plrPos -= diceRoll;
                        if (plrPos < MIN_POS)
                        {
                            plrPos = MIN_POS;
                        }
                        break;
                }
            }
            Console.WriteLine("Player position: " + plrPos + "\n");
        }
    }
}