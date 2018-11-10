using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 121;
            Console.WriteLine("Value : " + val);
            var IsPalindrome  = Palindrome.IsPalindrome(val);
            Console.WriteLine("Is Palindrome : " + IsPalindrome);
            Console.ReadLine();

        }

       
    }

    public static class Palindrome
    {
        //96 ms run time
        public static bool IsPalindrome(int x)
        {
            if (x < int.MaxValue && x > 0 && (x % 10 == 0 && x != 0))
                return false;
            int revertNumber = 0;
            while (x > revertNumber)
            {
                revertNumber = revertNumber * 10 +x % 10;
                x /= 10;
            }
            return x == revertNumber || x == revertNumber / 10;
        }

        //100 ms run time
        public static bool IsPalindromeTwo(int x)
        {
            if (x < int.MaxValue && x >= 0 && x % 10 == 0)
                return false;
            int revertNumber = 0;
            int tepm = x;
            while (tepm > 0)
            {
                revertNumber = revertNumber * 10 + tepm % 10;
                tepm /= 10;
            }
            return revertNumber == x;
        }
    }
}
