using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures
{
    public class Algorithms
    {
        public static int[] randomIntArray(int length)
        {
            int[] list = new int[length];
            Random rand = new Random();

            for (var i = 0; i < list.Length; i++)
            {
                list[i] = rand.Next(0, 1000);
            }
            return list;
        }

        public static int[] BubbleSort()
        {
            Console.Write("How long should our array be? ");
            int[] list = Algorithms.randomIntArray(Int32.Parse(Console.ReadLine()));

            UserInterface.Header("Original Random Integer Array");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n--------------------------------------------------------------");

            Timing timer = new Timing();
            timer.StartTime();

            foreach (var item in list)
            {
                var swapped = false;
                for (var i = 0; i < list.Count() - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        swapped = true;
                        var temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }

                list.ToList().ForEach(i => Console.Write(i.ToString() + " "));
                Console.WriteLine();

                if (swapped == false)
                {
                    break;
                }
            }

            timer.StopTime();

            UserInterface.Header("Bubble Sorted Array(" + timer.Result() + "s)");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            UserInterface.Header("Bubble Sort completed in: " + timer.Result() + "s");

            return list;
        }

        public static int[] InsertionSort([Optional]int[] list)
        {
            if (list == null)
            {
                Console.Write("How long should our array be? ");
                list = Algorithms.randomIntArray(Int32.Parse(Console.ReadLine()));
            }

            UserInterface.Header("Original Random Integer Array");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n--------------------------------------------------------------");

            Timing timer = new Timing();
            timer.StartTime();

            int n = list.Length;

            //Start looping one from the left (Splits list into sorted | unsorted)
            for (int j = 1; j < n; j++)
            {
                //Loop down from the index until you find an item smaller then those before it.
                //Then reapeated;y swap the smaller item with the larger before it,
                //once its correctly placed in the sorted side start moving upwards again.
                for (int i = j; i > 0 && list[i] < list[i - 1]; i--)
                {
                    var temp = list[i];
                    list[i] = list[i - 1];
                    list[i - 1] = temp;
                }
                list.ToList().ForEach(i => Console.Write(i.ToString() + " "));
                Console.WriteLine();
            }

            timer.StopTime();

            UserInterface.Header("Insertion Sorted Array: (" + timer.Result() + "s)");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            UserInterface.Header("Insertion Sort completed in: " + timer.Result() + "s)");

            return list;
        }
       
        public static bool BinarySearch([Optional]int i, [Optional]int[] list)
        {
            if(i == 0)
            {
                Console.WriteLine("What number would you like to find?");
                i = Int32.Parse(Console.ReadLine());
            }

            if (list == null)
            {
                Console.Write("How long should our array be? ");
                list = InsertionSort(randomIntArray(Int32.Parse(Console.ReadLine())));
            }

            int start = 0;
            int mid;
            int end = list.Length-1;
            int splitCount = 0;

            while (start <= end)
            {
                list.ToList().ForEach(x => Console.Write(x.ToString() + " "));
                Console.WriteLine();
                splitCount++;
                mid = (start + end) / 2;

                if(list[mid] == i)
                {
                    Console.WriteLine("Found " + i + " after " + splitCount + " attempts.");
                    return true;
                }
                else if (i < list[mid])
                {
                    Console.WriteLine(i + " is smaller than " + list[mid]);
                    end = mid - 1;
                }
                else
                {
                    Console.WriteLine(i + " is greater than " + list[mid]);
                    start = mid + 1;
                }
            };
            Console.WriteLine(i + " couldn't be found after " + splitCount);
            return false;
        }

        public static void Square()
        {
            Console.Write("Number you want squared? ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Input squared = " + n * n);
        }


        public static string CaesarCipher([Optional]string input, [Optional]int key)
        {
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("What string would you like to Cypher?");
                input = Console.ReadLine();
            }
            if (key == 0)
            {
                Console.WriteLine("What is your Cypher Key?");
                key = Int32.Parse(Console.ReadLine());
            }

            //turn string into array
            char[] newInput = input.ToCharArray();

            //loop through array
            for (var i = 0; i < newInput.Length; i++)
            {
                // zero out each array value then add value of key, and then MOD by 65, then reverse zeroing out
                Console.WriteLine("Original Char: " + newInput[i]);
                if (char.IsLetter(newInput[i]))
                {
                    if (char.IsLower(newInput[i]))
                    {
                        newInput[i] = Convert.ToChar((((newInput[i] - 97) + key) % 26) + 97);
                    }
                    if (char.IsUpper(newInput[i]))
                    {
                        newInput[i] = Convert.ToChar((((newInput[i] - 65) + key) % 26) + 65);
                    }
                }
                Console.WriteLine("New Char     : " + newInput[i]);
            }

            // turn array back into string
            string output = new string(newInput);

            Console.WriteLine(output);
            return output;
        }
    }
}
