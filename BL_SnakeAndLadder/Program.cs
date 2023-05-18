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
            const int MAX_POS = 20;
            int countOfRolls = 0, countOfRolls2 = 0;

            Console.WriteLine("Welcome to Snake & Ladder Game\n");
            int plrPos = 0, plrPos2 = 0; // Players Position
            //Console.WriteLine("Initial position of player is " + plrPos);

            int currentPlr = 1; //variable for player's turn, default first player is 1
            Console.WriteLine("Player number (who plays first, for First player enter 1 and for second player enter 2): ");
            currentPlr = Convert.ToInt32(Console.ReadLine()); //yet to handle the exception
            while (currentPlr != 1 && currentPlr != 2)
            {
                Console.WriteLine("\nPlayer number can only be eiter 1 or 2\nPlease enter a proper player number: ");
                currentPlr = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("Player {0} plays first\n", currentPlr);

            int diceRoll; // Dice rolling
            Random random = new Random();

            while (plrPos < MAX_POS && plrPos2 < MAX_POS) //play starts
            {
                if (currentPlr == 1)
                {
                    Console.WriteLine("First player's turn");
                    Console.WriteLine("Current position of player 1: " + plrPos);
                    diceRoll = random.Next(1, 7);
                    Console.WriteLine("Dice rolled: " + diceRoll);

                    int option = random.Next(0, 3);//0,1,2
                    switch (option)
                    {
                        case NO_PLAY:
                            Console.WriteLine("For this dice roll the move is  No Play");
                            currentPlr = 2;
                            break;
                        case LADDER:
                            Console.WriteLine("For this dice roll the move is  Ladder");
                            plrPos += diceRoll;
                            if (plrPos == MAX_POS)
                            {
                                Console.WriteLine("Player 1 won the game");
                                currentPlr = 1;
                                break;
                            }
                            if (plrPos > MAX_POS)
                            {
                                plrPos = plrPos - diceRoll;
                                Console.WriteLine("Player position can't be >100 hence not updating the position");
                            }
                            currentPlr = 1; // For ladder current player gets to play again
                            break;
                        case SNAKE:
                            Console.WriteLine("For this dice roll the move is  Snake");
                            plrPos -= diceRoll;
                            if (plrPos < MIN_POS)
                            {
                                plrPos = MIN_POS;
                                Console.WriteLine("Player position can't be -ve hence resetting to 0");
                            }
                            currentPlr = 2;
                            break;
                    }
                    Console.WriteLine("First player's position updated to: " + plrPos + "\n");
                    countOfRolls++;
                }
                else if (currentPlr == 2)
                {
                    Console.WriteLine("Second player's turn");
                    Console.WriteLine("Current position of player 2: " + plrPos2);
                    diceRoll = random.Next(1, 7);
                    Console.WriteLine("Dice rolled: " + diceRoll);
                    int option = random.Next(0, 3);//0,1,2
                    switch (option)
                    {
                        case NO_PLAY:
                            Console.WriteLine("For this dice roll the move is  No Play");
                             currentPlr = 1;
                              break;
                        case LADDER:
                            Console.WriteLine("For this dice roll the move is  Ladder");
                            plrPos += diceRoll;
                            if (plrPos2 == MAX_POS)
                            {
                                Console.WriteLine("Player 2 won the game");
                                currentPlr = 2; // For ladder current player gets to play again
                                break;
                            }
                            if (plrPos > MAX_POS)
                            {
                                plrPos = plrPos - diceRoll;
                                Console.WriteLine("Player position can't be >100 hence not updating the position");
                             }
                             currentPlr = 2;
                            break;
                        case SNAKE:
                            Console.WriteLine("For this dice roll the move is  Snake");
                            plrPos -= diceRoll;
                            if (plrPos < MIN_POS)
                            {
                                plrPos = MIN_POS;
                                Console.WriteLine("Player position can't be -ve hence resetting to 0");
                            }
                            currentPlr = 1;
                            break;
                        }
                    Console.WriteLine("Second player's position updated to: " + plrPos2 + "\n");
                    countOfRolls2++;
                }
                //Console.WriteLine("Player position: " + plrPos + "\n");
            }
            Console.WriteLine("Total count of dice rolls for player 1: " + countOfRolls);
            Console.WriteLine("Total count of dice rolls for player 2: " + countOfRolls2);
            Console.WriteLine("Player {0} won the game", currentPlr);
        }
    }
}