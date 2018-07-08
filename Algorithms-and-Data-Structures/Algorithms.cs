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


        public static int Square(int n)
        {
            return n * n;
        }
    }
}
