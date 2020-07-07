using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharp
{
    public class Basic
    {
        //Print 1-255
        public static void Print()
        {

            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Print odd
        public static void PrintOdd()
        {
            for (int i = 0; i < 256; i++)
            {
                var result = i % 2;
                if (result == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        //Print Sum
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;

                Console.WriteLine(i);
            }
        }

        //Print odd
        public static void PrintArray(params int[] arrays)
        {
            foreach (var item in arrays)
            {
                Console.WriteLine(item);
            }

        }

        public static void PrintMax(params int[] arrays)
        {
            int max = arrays[0];
            foreach (var item in arrays)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);
        }

        public static void OddArray()
        {
            var y = new List<int>();
            for (int i = 0; i <256 ; i++)
            {
                if (i % 2!=0)
                {
                    y.Add(i);
                }
            }

            foreach (var item in y)
            {
                Console.WriteLine(item);
            }
        }

        //Greater than y
        public static void GTY(int y,params int[] values)
        {
            foreach (var item in values)
            {
                if (y > item)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine($"{item} Value is greater than Y ");
                }
            }
        }
    }
}