using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

            for(var i = 0; i < list.Length; i++)
            {
                list[i] = rand.Next(0, 1000);
            }
            return list;
        }

        public static int[] BubbleSort()
        {
            Console.Write("How long should our array be? ");
            int[] list = Algorithms.randomIntArray(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Original Random Integer Array");
            Console.WriteLine("-------------------------------");
            foreach ( var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-------------------------------");

            foreach (var item in list)
            {
                var swapped = false;
                for(var i = 0; i < list.Count() - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        swapped = true;
                        var temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
                Console.Write("Iteration(" + item + "): ");
                foreach (var item2 in list)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
                if ( swapped == false)
                {
                    break;
                }
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Bubble Sorted Array");
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-------------------------------");

            return list;
        }

        public static int[] InsertionSort()
        {
            int[] list = Algorithms.randomIntArray(Int32.Parse(Console.ReadLine()));
            return list;
        }

        public static void Square()
        {
            Console.Write("Number you want squared? ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Input squared = " + n * n);
        }
    }
}
