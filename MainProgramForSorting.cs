using System;

namespace SortingInCSharp
{
    class MainProgramForSorting
    {
        static void Main(string[] args)
        {
            //InsertionSort
            int[] arr = { 12, 11, 13, 5, 6 };
            Console.WriteLine("Welcome to Insertion sort. Sorted array is: ");
            InsertionSort ob = new InsertionSort();
            ob.sort(arr);

        }
    }
}
