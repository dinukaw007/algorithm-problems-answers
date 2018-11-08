using System;

namespace StringToIntegerAtoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "-91283472332";
            Console.WriteLine("Number String : {0}", value);
            Console.WriteLine("String to Integer : {0}", StringToInteger.MyAtoi(value));
            Console.ReadLine();
        }
    }

    public static class StringToInteger
    {
        public static int MyAtoi(string str)
        {
            long res = 0;
            var sign = 1;            
            str = str.Trim();
            if (string.IsNullOrEmpty(str)) return 0;
            int index = 0;
            if (str[0] == '+' || str[0] =='-')
            {
                sign = str[0] == '+' ? 1 : -1;
                index++;
            }
            while (index<str.Length)
            {
                if (char.IsNumber(str[index]))
                {
                    res = res * 10 + str[index] - '0';
                    if (res * sign > int.MaxValue) return int.MaxValue;
                    if (res * sign < int.MinValue) return int.MinValue;
                }
                else
                {
                    break;
                }
                index++;
            }
            return (int)res * sign;
        }

    }
}
