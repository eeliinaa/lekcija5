using System;
using System.Collections.Generic;
using System.Linq;

namespace lekcija5
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskSum3();
            //TaskMaxEnd3();
        }

        static void TaskSum3()
        {
            int[] array1 = { 3, 2, 3 };
            var sum = 0;
            foreach(var i in array1)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
        static void TaskMaxEnd3()
        {
            int[] array1 = { 5, 2, 3 };

            Console.WriteLine("Array:");
            foreach (var item in array1)
            {
                Console.WriteLine(item.ToString());
            }
            if (array1.Length > 0)
            {
                var arrLength = array1.Length;
                var arrLargestNr = array1.Max();
                for (var i = 0; i < arrLength ; i++)
                {
                    array1[i] = arrLargestNr;
                }
                Console.WriteLine("New array:");
                foreach (var item in array1)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("Array is empty!");
            }
        }
    }
}
