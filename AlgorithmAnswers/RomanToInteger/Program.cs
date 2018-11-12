using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var romanValue = "MCMXCIV";
            Console.WriteLine("Romain Numver : {0}",romanValue);
            Console.WriteLine("Integer Value : {0}", RomanToIntegerNumber.RomanToIntTwo(romanValue));
            Console.Read();
        }
    }

  public static class RomanToIntegerNumber
  {
        public static int RomanToInt(string s)
        {
            if (s == null || s.Length == 0) return 0;

            var length = s.Length;
            var dict = RomanToIntegerDictionary();
            var spwcdict = RomanToIntegerSpecialDictionary();
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (i + 1 < length)
                {
                    var key = s.Substring(i, 2);
                    if (spwcdict.ContainsKey(key))
                    {
                        sum += spwcdict[key];
                        i++;
                        continue;
                    }
                }
                sum += dict[s[i]];
            }
            return sum;
        }
        public static int RomanToIntTwo(string s)
        {
            int result = 0;
            int i = 0;
            var convertRoman = RomanToIntegerDictionary();
            while (i<s.Length -1)
            {
                int currentAmount = convertRoman[s[i]];
                int nextAmount = convertRoman[s[i + 1]];
                if (nextAmount > currentAmount)
                {
                    result += (nextAmount - currentAmount);
                    i += 2;
                }
                else
                {
                    result += currentAmount;
                    i++;
                }
            }
            if (i == s.Length - 1)
            {
                int currentAmount = convertRoman[s[i]];
                result += currentAmount;
            }
            return result;
        }
        private static IDictionary<char, int> RomanToIntegerDictionary()
        {
            var dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);           
            return dict;
        }
        private static IDictionary<string, int> RomanToIntegerSpecialDictionary()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("IV", 4);
            dict.Add("IX", 9);
            dict.Add("XL", 40);
            dict.Add("XC", 90);
            dict.Add("CD", 400);
            dict.Add("CM", 900);
            return dict;
        }
    }
}
