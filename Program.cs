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
            string dir = Directory.GetCurrentDirectory();
            dir.Replace(@"\", @"/");
            dir += "/prefs.txt";
            Console.WriteLine("Select from the following options");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1 Write an email");
            Console.WriteLine("2 View current preferences");
            Console.WriteLine("3 Change preferences");
            Console.WriteLine("4 Exit");
            string input = Console.ReadLine();
            try {
            switch (input)
            {
                case "1":
                    //xxxxx
                    break;
                case "2":
                    StreamReader sr = new StreamReader(dir);
                    string line = sr.ReadLine();
                    int ai = line.IndexOf("]");
                    ai++;
                    string addressee = line.Substring(ai);
                    Console.WriteLine($"Your current addressee is {addressee}");
                    line = sr.ReadLine();
                    int si = line.IndexOf("]");
                    si++;
                    string sign = line.Substring(si);
                    Console.WriteLine($"Your current signature is {sign}");
                    sr.Close();
                    break;
                case "3":
                    Console.WriteLine("Please enter your default addressee (i.e. To whom it may concern)");
                    string addressee2 = Console.ReadLine();
                    StreamWriter sr2 = new StreamWriter(dir);
                    sr2.WriteLine($"[addressee]{addressee2}");

                    Console.WriteLine("Please enter your signature (i.e. Jack Johnson)");
                    string sign2 = Console.ReadLine();
                    sr2.WriteLine($"[signature]{sign2}");
                    sr2.Close();
                    Console.WriteLine("Your preferences have been set");
                    break;
                case "4":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid input, please refer to the guide above for the available commands");
                    break;
            }
            } catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        }
    }
}
