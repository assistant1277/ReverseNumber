using ReverseNumber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to reverse ");
            int inputNumber = int.Parse(Console.ReadLine());
            Reverse.CheckAndPrintReverse(inputNumber);
            Console.ReadKey();
        }
    }
}
