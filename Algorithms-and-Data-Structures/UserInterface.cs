using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures
{
    public class UserInterface
    {
        public static void MainMenu()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("-------------------------------");
            Console.Write("1. Caesar's Cypher\n" +
                          "2. Vigenere's Cipher\n" +
                          "3. Number Squared\n");

            Console.WriteLine("-------------------------------");
            string choice = Console.ReadLine();
            Console.WriteLine("-------------------------------");

            switch (choice)
            {
                case "1":
                    //CaesarCipher();
                    break;
                case "2":
                    //VigenereCipher();
                    break;
                case "3":
                    Console.WriteLine("Number you want squared?");
                    Console.WriteLine("-------------------------------");
                    int n = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine(Algorithms.Square(n));

                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Selection.....");
                    Console.WriteLine("-------------------------------");
                    MainMenu();
                    break;
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Return to menu? (Y) || Exit (X)");
            Console.WriteLine("-------------------------------");
            string userComplete = Console.ReadLine();
            switch (userComplete)
            {
                case "y":
                    MainMenu();
                    break;
                case "Y":
                    MainMenu();
                    break;
                case "n":
                    Environment.Exit(0);
                    break;
                case "N":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
