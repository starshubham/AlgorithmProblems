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

            //Bubble Sort
            int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort obj1 = new BubbleSort();
            obj1.bubbleSort(arr1);
            Console.WriteLine("\nWelcome to Bubble sort. Sorted array is: ");
            obj1.printArray1(arr1);

            // Merge Sort
            int[] arr2 = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("\nWelcome to Bubble sort: ");
            Console.WriteLine("Given Array");
            MergeSort ob2 = new MergeSort();
            ob2.printArray2(arr2);

            ob2.sort(arr2, 0, arr2.Length - 1);
            Console.WriteLine("\nSorted array");
            ob2.printArray2(arr2);
        }
    }
}
