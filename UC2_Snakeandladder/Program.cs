using System;

namespace UC2_Snakeandladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine(" dice number is " +dice);
        }
    }
}
