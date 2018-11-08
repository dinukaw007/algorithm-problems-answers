using System;

namespace ZigZagConversion
{

    /*
     * 
     *ZigZag Conversion    
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            var convert_string = ZigZag.ConvertZigZag("PAYPALISHIRING", 4);
            Console.WriteLine(convert_string);
            Console.ReadLine();
        }
       
    }

    public static class ZigZag
    {
        //100 ms Runtime
        public static string ConvertZigZag(string s, int numRows)
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
