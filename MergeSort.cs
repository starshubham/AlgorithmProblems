using System;
/*
Merge Sort - Like QuickSort, Merge Sort is a Divide and Conquer algorithm. It divides the input array into two halves, 
calls itself for the two halves, and then merges the two sorted halves. 
The merge() function is used for merging two halves. The merge(arr, l, m, r) is a key process 
that assumes that arr[l..m] and arr[m+1..r] are sorted and merges the two sorted sub-arrays into one.
MergeSort(arr[], l,  r)
If r > l
     1. Find the middle point to divide the array into two halves:  
             middle m = l+ (r-l)/2
     2. Call mergeSort for first half:   
             Call mergeSort(arr, l, m)
     3. Call mergeSort for second half:
             Call mergeSort(arr, m+1, r)
     4. Merge the two halves sorted in step 2 and 3:
             Call merge(arr, l, m, r)
*/

namespace SortingInCSharp
{
    public class MergeSort
    {
        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]
        void merge(int[] arr2, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr2[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr2[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr2[k] = L[i];
                    i++;
                }
                else
                {
                    arr2[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr2[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr2[k] = R[j];
                j++;
                k++;
            }
        }
        // Main function that
        // sorts arr[l..r] using
        // merge()
        public void sort(int[] arr2, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                sort(arr2, l, m);
                sort(arr2, m + 1, r);

                // Merge the sorted halves
                merge(arr2, l, m, r);
            }
        }

        // A utility function to
        // print array of size n */
        public void printArray2(int[] arr2)
        {
            int n = arr2.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr2[i] + " ");
            Console.WriteLine();
        }
    }
}
