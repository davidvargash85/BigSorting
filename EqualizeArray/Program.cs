using System;

namespace EqualizeArray
{
    class Program
    {
        static int EqualizeArray(int[] arr)
        {
            // Complete this function

            int max = 0;
            int[] d = new int[101];
            for (int i = 0; i < arr.Length; i++)
            {
                d[arr[i]]++;
                if (d[arr[i]] > max)
                    max = d[arr[i]];
            }

            return arr.Length - max;
        }

        static void Main(String[] args)
        {
            string x = "3";
            string[] arr_temp = x.Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = EqualizeArray(arr);
            Console.WriteLine(result);
        }
    }
}
