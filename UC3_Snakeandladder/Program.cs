using System;

namespace UC3_Snakeandladder
{
    class Program
    {
        static void Main(string[] args)
        {
          const  int IS_NOPLAY = 1;
           const int IS_LADDER = 2;
           const int IS_SNAKE = 3;
            int position = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            int option = random.Next(1, 4);
            switch (option)
            {
                case IS_NOPLAY:
                    position = 0;
                    break;
                case IS_SNAKE:
                    position = position - dice;
                    break;
                case IS_LADDER:
                    position = position + dice;
                    break;
            }
            Console.WriteLine(" position is = " + position);
        }
    }
}
