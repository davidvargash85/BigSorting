using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseAnd
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] result = new int[t];
            int c = 0, v = 0, ij = 0;
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);

                v = ij = 1 & 2;
                for (int i = 1; i < n; i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        v = i & j;
                        if (v > ij && v < k)
                            ij = v;
                    }
                }
                result[c++] = ij;
            }

            for (int i = 0; i < t; i++)
                Console.WriteLine(result[i]);
        }
    }
}
