using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber.model
{
    public class Reverse
    {
        public static int ReverseDigits(int number)
        {
            int reversedNumber = 0;
            while(number > 0)
            {
                int lastDigit = number % 10;
                reversedNumber = (reversedNumber * 10) + lastDigit;
                number /= 10;
            }

            return reversedNumber;
        }
        public static void CheckAndPrintReverse(int number)
        {
            int reversed = ReverseDigits(number);
            Console.WriteLine($"reverse of number {number} is {reversed}");
        }
    }
}
