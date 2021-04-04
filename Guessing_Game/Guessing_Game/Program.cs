using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[]args)
        {
            string secretWord = "MissingWord";
            string guess = "";
            int guesscount = 0;
            int guesslimit = 4;
            bool outOfguess = false;

            while (guess != secretWord && !outOfguess)
            {
                if(guesscount < guesslimit) 
                {
                    Console.Write("Enter guess:-");
                    guess = Console.ReadLine();
                    guesscount++;
                }
                else 
                {
                    outOfguess = true;
                }
            }
            if(outOfguess)
            {
                Console.Write("opps better luck next time");
            }
            else
            {
                Console.Write("yeah you got it");
            }
        }
    }
}
