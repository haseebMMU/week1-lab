using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace week1_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num1;
            int num2;

            Console.WriteLine("Enter the first number:");
            input = Console.ReadLine();
            num1 = Convert.ToInt32(input);

            Console.WriteLine("Enter the second number: ");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);

            Console.WriteLine("Sum: " + sum(num1, num2));
            Console.WriteLine("Multipication: " + multi(num1, num2));
            Console.WriteLine("Power: " + power(num1, num2));
            Console.ReadKey();
        }

        static int sum(int x, int y)
        {
            return x + y;
        }

        static int multi(int x, int y)
        {
            return x * y;
        }

        static int power(int x, int y)
        {
            int powerX = x;

            for(int i = 1; i < y; i++)
            {
                powerX = powerX * x;
            }

            return powerX;
        }
    }
}
