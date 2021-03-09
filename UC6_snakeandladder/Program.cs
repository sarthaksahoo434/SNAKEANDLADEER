using System;

namespace UC6_snakeandladder
{
    class Program
    {
      
        public const int NO_PLAY = 0;
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        public const int WINNING_POSITION = 10;


        Random random = new Random();
        public int DiceRoll()
        {
            int diceRoll = random.Next(1, 7);
            return diceRoll;
        }
        public int OptionCheck()
        {
            int optionCheck = random.Next(0, 3);
            return optionCheck;
        }

        static void Main(string[] args)
        {
            int diceCount = 0;
            Program program = new Program();

            int playerPosition = 0;

            while (true)
            {
                int diceRoll = program.DiceRoll();
                Console.WriteLine("Dice" + diceRoll);
                diceCount++;
                int optionCheck = program.OptionCheck();
                Console.WriteLine("Option " + optionCheck);


                if (playerPosition + diceRoll > WINNING_POSITION)
                {
                    optionCheck = NO_PLAY;
                }

                switch (optionCheck)
                {
                    case NO_PLAY:
                        break;
                    case IS_LADDER:
                        playerPosition += diceRoll;
                        break;
                    case IS_SNAKE:
                        playerPosition -= diceRoll;
                        break;
                }
                if (playerPosition == WINNING_POSITION)
                {
                    Console.WriteLine("Number of times Dice Rolled : " + diceCount);
                    break;
                }
                else if (playerPosition < 0)
                {
                    playerPosition = 0;
                }
                Console.WriteLine("Player Position :" + playerPosition);
            }
            Console.WriteLine("Final Player Position :" + playerPosition);
        }
    }
}