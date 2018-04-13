using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            string hs = s.Substring(0, 2);
            int hi = Int32.Parse(hs);

            char ampm = s[8];
            if (ampm == 'P')
            {
                if (hi != 12)
                    hi += 12;
            }
            else
            {
                if (hi == 12)
                    hi = 0;
            }

            return string.Format("{0:00}{1}", hi, s.Substring(2, 6));
        }

        static void Main(string[] args)
        {
            string s = "12:00:00AM";

            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
