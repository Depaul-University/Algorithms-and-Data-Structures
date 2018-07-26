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
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("1. Bubble Sort\n" +
                          "2. Insertion Sort\n" +
                          "3. Binary Search\n" +
                          "4. Caesar Cypher\n" +
                          "99. Number Squared\n");
            Console.WriteLine("--------------------------------------------------------------");
            string choice = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------");

            switch (choice)
            {
                case "1":
                    Algorithms.BubbleSort();
                    break;
                case "2":
                    Algorithms.InsertionSort();
                    break;
                case "3":
                    Algorithms.BinarySearch();
                    break;
                case "4":
                    Algorithms.CaesarCipher();
                    break;
                case "99":
                    Algorithms.Square();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Selection.....");
                    Console.WriteLine("--------------------------------------------------------------");
                    MainMenu();
                    break;
            }

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Return to menu? (Y) || Exit (X)");
            Console.WriteLine("--------------------------------------------------------------");
            string userComplete = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------");

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

        public static void Header(string header)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(header);
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
