using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10;

            int n = 6;
            int[] arr = new int[] { 1, 4, 3, 5, 6, 2 };

            InsertionSort1(n, arr);
        }

        static void InsertionSort1(int n, int[] arr)
        {
            // Complete this function
            int e = 0;
            int pos = 0;
            for (int i = 0; i < n; i++)
            {
                e = arr[n - 1];
                pos = n - 1;
                while (pos > i)
                {
                    if (arr[pos - 1] > e)
                        arr[pos] = arr[pos - 1];
                    pos--;
                }
                arr[pos] = e;
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
