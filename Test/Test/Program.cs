using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GetUserInfo();
            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string userGuess = Console.ReadLine();
                    if (!int.TryParse(userGuess, out guess))
                    {
                        PrintColorAndMessage(ConsoleColor.DarkRed, "Please write a number");
                        continue;
                    }
                    guess = Int32.Parse(userGuess);
                    if (guess != correctNumber)
                    {
                        PrintColorAndMessage(ConsoleColor.DarkRed, "You're wrong");
                    }
                    else
                    {
                        PrintColorAndMessage(ConsoleColor.Green, "You're correct");
                    }
                }
                Console.WriteLine("Do you want to play again?(Y/N)");
                string userAnswer = Console.ReadLine().ToUpper();
                if (userAnswer == "Y")
                {
                    continue;
                }
                else if (userAnswer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
                Console.ResetColor();
            }
        
        }
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "LUL";


            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
        }
        static void GetUserInfo()
        {
            Console.Write("What is your name?Please type your name -> ");

            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play game", input);
        }
        static void PrintColorAndMessage(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
