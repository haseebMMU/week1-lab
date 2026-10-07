using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.ReadKey();
        }
    }
}
