using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5"};

            string[] result = BigSorting(arr);
            Console.WriteLine(String.Join("\n", result));
        }

        static string[] BigSorting(string[] arr)
        {
            // Complete this function

            Array.Sort(arr, new StringComparer());
            return arr;
        }
    }

    internal class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int xl = x.Length;
            int yl = y.Length;
            
            if (xl != yl)
                return xl - yl;
            else
            {
                int c = xl > yl ? yl : xl;
                for (int i = 0; i < c; i++)
                {
                    if (x[i] == y[i])
                        continue;
                    return x[i] - y[i];
                }
            }

            return 0;
        }
    }
}
