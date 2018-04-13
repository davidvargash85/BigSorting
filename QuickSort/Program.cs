using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9, 8, 6, 7, 3, 5, 4, 1, 2 };
            QuickSort(arr, 0, arr.Length-1);
            //int ppos = Partition(arr, 0, 6);
            //Console.WriteLine(ppos);
        }

        static void QuickSort(int[] arr, int l, int r)
        {
            if (l >= r)
                return;

            int ppos = Partition(arr, l, r);

            QuickSort(arr, l, ppos - 1);
            QuickSort(arr, ppos + 1, r);
        }

        static int Partition(int[] arr, int l, int r)
        {
            int p = arr[r], i = l, c = l;

            while(i < r)
            {
                if (arr[i] < p)
                {
                    Swap(arr, c, i);
                    c++;
                }
                i++;
            }
            Swap(arr, c, i);

            return c;
        }

        static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

    }
}
