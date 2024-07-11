using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, factorial = 1;
            Console.WriteLine("Enter the number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            for (int i = number1; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of " + number1 + " is " + factorial);
            Console.ReadLine();
        }
    }

}
