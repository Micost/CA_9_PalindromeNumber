using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_9_PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1234321;
            Solution s1 = new Solution();
            Console.Write(s1.IsPalindrome(input));
            var a = Console.ReadKey();
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            else if (x < 10)
                return true;
            int input = x;
            int reverseX = 0;
            while (true)
            {
                if (input == 0)
                    break;
                try
                {
                    reverseX = checked(10 * reverseX + input % 10);
                    input = input / 10;
                }
                catch(OverflowException)
                {
                    return false;
                }
            }
            return x == reverseX;
        }
    }
}
