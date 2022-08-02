using System;

namespace The_Beginning
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "A Window";
            Console.WriteLine("Hello I am a C# Program!");
            Console.WriteLine("What is your name?: ");
            Console.ReadLine();
            Console.WriteLine("That is a really nice name! \nLet's keep the conversation going!");
            Console.WriteLine("What is your favorite color?: ");
            var textColor  = Console.ReadLine();
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), textColor, true);
            Console.WriteLine("That is a nice color! :) \nJust for you, I have displayed your favorite color!");
            Console.WriteLine("I hope that makes you happy hehe :D");
            Console.WriteLine("I have a surprise for you! Why dont you type your other favorite color? ");
            Console.WriteLine("I promise that you will like it! Please type it: ");
            var backgroundColor  = Console.ReadLine();
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backgroundColor, true);
            Console.WriteLine("Tada! Did you like it? (type Y/N): ");
            var input = Console.ReadKey();
            if (input.KeyChar == 'Y' || input.KeyChar == 'y' )
            {
                Console.WriteLine("\nYay! \nThanks for playing with me! I hope to see you again!");
            }
            else if (input.KeyChar == 'N' || input.KeyChar == 'n')
            {
                Console.WriteLine("\n:( \n That is not a nice thing to say. I am sad. Good bye :,( ");
            }
            else
            {
                Console.WriteLine("\nI did not understand! I am too confused now. Good bye!");
            }
            Console.ReadKey();
           
        }
    }
}