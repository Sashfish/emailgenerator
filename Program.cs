using System;
using System.IO;

namespace emailgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1==1)
            {
            Console.WriteLine("Select from the following options");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1 Write an email");
            Console.WriteLine("2 View current preferences");
            Console.WriteLine("3 Change preferences");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //xxxxx
                    break;
                case "2":
                    //xxxx
                    break;
                case "3":
                    //xxx
                    break;
                default:
                    Console.WriteLine("Invalid input, please refer to the guide above for the available commands");
                    break;
            }
            }
        }
    }
}
