using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written by Glenn Dailey

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // create array size of 10
            int array_size = 10;
            // place items in array unsorted
            int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            // print the array before the sort is done
            Console.WriteLine("The Array Before Selection Sort is: ");
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine(array[i]);
            }

            // create loops, temp, min_key to sort the array
            int temp, min_key;
            for (int j = 0; j < array_size - 1; j++)
            {
                min_key = j;
                for (int k = j +1; k < array_size; k++)
                {
                    if (array[k] < array[min_key])
                    {
                        min_key = k;
                    }
                }
                temp = array[min_key];
                array[min_key] = array[j];
                array[j] = temp;
            }

            // print the sorted array
            Console.WriteLine("The Array After Selection Sort is: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
