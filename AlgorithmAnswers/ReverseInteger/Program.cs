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
        //44  ms Runtime
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

        public static int ReverseTwo(int x)
        {
            long rev = 0, g = x;
            while (x != 0)
            {
                long digit = x % 10;
                rev = rev * 10 + digit;
                x = x / 10;
                if (rev < int.MaxValue - 1 && rev > int.MinValue)
                {
                    if (g > 0 && (rev < 0 || (rev >= int.MaxValue - 1)) ||
                       (g < 0 && (rev > 0 || (rev <= int.MinValue))))
                    {
                        if (rev < 0 || (rev >= int.MaxValue - 1))
                        {
                            rev = 0;
                            break;
                        }
                    }
                }
                else rev = 0;
            }
            return (int)rev;
        }
    }
    }
