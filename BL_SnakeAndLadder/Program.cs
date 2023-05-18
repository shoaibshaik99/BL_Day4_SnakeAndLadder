namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            int player1 = 0, player2 = 0;
            int currentPlayer = 1;
            int diceValue = 0;
            int ladder = 0, snake = 0;
            Random random = new Random();
            while (player1 < 100 && player2 < 100)
            {
                Console.WriteLine("Player " + currentPlayer + " turn");
                diceValue = random.Next(1, 7);
                Console.WriteLine("Dice Value: " + diceValue);
                if (currentPlayer == 1)
                {
                    player1 += diceValue;
                    if (player1 > 100)
                    {
                        player1 -= diceValue;
                        Console.WriteLine("Invalid Move");
                    }
                    else if (player1 == 100)
                    {
                        Console.WriteLine("Player " + currentPlayer + " wins");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Player " + currentPlayer + " position: " + player1);
                        ladder = random.Next(1, 7);
                        snake = random.Next(1, 7);
                        if (ladder == diceValue)
                        {
                            Console.WriteLine("Ladder");
                            player1 += ladder;
                            Console.WriteLine("Player " + currentPlayer + " position: " + player1);
                        }
                        else if (snake == diceValue)
                        {
                            Console.WriteLine("Snake");
                            player1 -= snake;
                            Console.WriteLine("Player " + currentPlayer + " position: " + player1);
                        }
                    }
                    currentPlayer = 2;
                }
                else
                {
                    player2 += diceValue;
                    if (player2 > 100)
                    {
                        player2 -= diceValue;
                        Console.WriteLine("Invalid Move");
                    }
                    else if (player2 == 100)
                    {
                        Console.WriteLine("Player " + currentPlayer + " wins");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Player " + currentPlayer + " position: " + player2);
                        ladder = random.Next(1, 7);
                        snake = random.Next(1, 7);
                        if (ladder == diceValue)
                        {
                            Console.WriteLine("Ladder");
                            player2 += ladder;
                            Console.WriteLine("Player " + currentPlayer + " position: " + player2);
                        }
                        else if (snake == diceValue)
                        {
                            Console.WriteLine("Snake");
                            player2 -= snake;
                            Console.WriteLine("Player " + currentPlayer + " position: " + player2);
                        }
                    }
                    currentPlayer = 1;
                }
            }

            Console.ReadLine();
        }
    }
}