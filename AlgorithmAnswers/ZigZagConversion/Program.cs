using System;

namespace ZigZagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var convert_string = Convert("PAYPALISHIRING", 3);
            Console.WriteLine(convert_string);
            Console.ReadLine();
        }

        private static string Convert(string s,  int numRows)
        {
            if (numRows == 1) return s;
            string ret = "";
            int n = s.Length;
            char[] sArray = s.ToCharArray();
            int cycelLen = 2 * numRows - 2;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j + i < n; j += cycelLen)
                {
                    ret = string.Concat(ret, sArray[j + i]);
                    if (i != 0 && i != numRows - 1 && j + cycelLen - i < n)
                    {
                        ret += string.Concat(sArray[j + cycelLen - i]);
                    }
                }
            }
            return ret;
        }
    }
}
