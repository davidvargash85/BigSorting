using System;

namespace SherlockAndTheBeast
{
    class Program
    {
        static void Main(string[] args)
        {
            DecentNumber(100000);
        }

        static void DecentNumber(int n)
        {
            int f = n / 3;
            bool found = false;

            for (int i = f; i >= 0; i--)
            {
                if ((((n - 3 * i) % 5) == 0))
                {
                    found = true;
                    f = i;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("-1");
                return;
            }

            for (int i = 0; i < n; i++)
                Console.Write((i < 3*f) ? "5" : "3");
            Console.WriteLine();
        }
    }
}

