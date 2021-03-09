using System;

namespace UC4_snakeandladeer
{
    class Program
    {
        public const int NO_PLAY = 0;
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        public const int WINNING_POSITION = 100;

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
            Program program = new Program();

            int playerPosition = 0;

            while (true)
            {
                int diceRoll = program.DiceRoll();
                Console.WriteLine("Dice" + diceRoll);
                int optionCheck = program.OptionCheck();
                Console.WriteLine("Option " + optionCheck);

                switch (optionCheck)
                {
                    case NO_PLAY:
                        playerPosition = 0;
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
                    break;
                }
                else if (playerPosition < 0)
                {
                    playerPosition = 0;
                }

            }
            Console.WriteLine("Player Position :" + playerPosition);
        }
    }
}
