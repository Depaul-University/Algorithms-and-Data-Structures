using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

            Timing timer = new Timing();
            timer.StartTime();

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
                //Console.Write("Iteration(" + item + "): ");
                //foreach (var item2 in list)
                //{
                //    Console.Write(item2 + " ");
                //}
                //Console.WriteLine();
                if ( swapped == false)
                {
                    break;
                }
            }

            timer.StopTime();

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Bubble Sorted Array(" + timer.Result() + "s)");
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Bubble Sort completed in: " + timer.Result() + "s");
            Console.WriteLine("-------------------------------");

            return list;
        }

        public static int[] InsertionSort()
        {
            Console.Write("How long should our array be? ");
            int[] list = Algorithms.randomIntArray(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Original Random Integer Array");
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-------------------------------");

            Timing timer = new Timing();
            timer.StartTime();

            int n = list.Length;

            for (int j = 1; j < n; j++)
            {
                for (int i = j; i > 0 && list[i] < list[i - 1]; i--)
                {
                    var temp = list[i];
                    list[i] = list[i-1];
                    list[i-1] = temp;
                }
            }

            timer.StopTime();

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Insertion Sorted Array: ("+ timer.Result() + "s)");
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Insertion Sort completed in: " + timer.Result() + "s)");
            Console.WriteLine("-------------------------------");

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
