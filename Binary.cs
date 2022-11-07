using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationPrac
{
    internal class Binary: QuickSearch
    {
        static void Main(string[] args)
        {
            //Selected Sort
            int[] arr = new int[20] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34, 11, 34, 64, 59, 2, 55, 36, 94, 74, 81 };
            int n = 20;
            Console.WriteLine("Selection sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            //gets smallest num
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine();
            Console.Write("Sorted array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
            Console.ReadLine();
            //Quick Search
            int[] arrs = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            int x = 10, z;
            Console.WriteLine("Quick Sort");
            Console.Write("Initial array is: ");
            for (z = 0; z < x; z++)
            {
                Console.Write(arrs[z] + " ");
            }

            quickSort(arrs, 0, 9);
            Console.Write("Sorted Array is: ");
            for (z = 0; z < x; z++)
            {
                Console.Write(arrs[z] + " ");
            }
            Console.ReadLine();
        }
    }
}
