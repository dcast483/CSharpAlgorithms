using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorts
{
    internal class Program
    {
        void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;

            // Initial index of merged
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function
        void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                int m = l + (r - l) / 2;

                sort(arr, l, m);
                sort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }

        // A utility function to
        // print array of size n */
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Driver code
        public static void Main(String[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7, 21, 26, 2, 15, 34, 57, 90, 81, 53, 64, 55, 77, 22, 35, 66, 68, 74, 82, 76 };
            Console.WriteLine("Given Array");
            printArray(arr);
            Program ob = new Program();
            ob.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
            Console.ReadLine();
        }
    }
}

