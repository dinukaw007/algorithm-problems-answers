using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 1534236469;
          
            Console.WriteLine("Number : {0}", Number);
            Console.WriteLine("Reverse Number : {0}", ReverseInt.Reverse(Number));
            Console.Read();
        }

       
    }

    public static class ReverseInt
    {
        public static int Reverse(int x)
        {
            int ReversNumber = 0;
            while (x != 0)
            {
                int Remainder = x % 10;
                x /= 10;
                if (ReversNumber > int.MaxValue / 10) return 0;
                if (ReversNumber < int.MinValue / 10) return 0;
                ReversNumber = (ReversNumber * 10) + Remainder;

            }
            return ReversNumber;
        }
    }
    }
