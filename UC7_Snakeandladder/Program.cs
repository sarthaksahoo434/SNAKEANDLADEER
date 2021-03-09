using System;

namespace UC7_Snakeandladder
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
        public int Play(int playerPosition)
        {
            Program program = new Program();
            int diceRoll = program.DiceRoll();
            Console.WriteLine("Dice" + diceRoll);

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
            if (optionCheck == IS_LADDER)
            {
                this.Play(playerPosition);
            }
            return playerPosition;
        }
        static void Main(string[] args)
        {

            Program program = new Program();

            int playerOnePosition = 0;
            int playerTwoPosition = 0;


            while (true)
            {
                playerOnePosition = program.Play(playerOnePosition);
                playerTwoPosition = program.Play(playerTwoPosition);

                if (playerOnePosition == WINNING_POSITION)
                {
                    Console.WriteLine("Player One wins..");
                    break;
                }
                else if (playerTwoPosition == WINNING_POSITION)
                {
                    Console.WriteLine("Player Two wins..");
                    break;
                }
                else if (playerOnePosition < 0)
                {
                    playerOnePosition = 0;
                }
                else if (playerTwoPosition < 0)
                {
                    playerTwoPosition = 0;
                }
                
            }
            
        }
    }
}