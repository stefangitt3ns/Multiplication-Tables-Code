using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.Title = "Multiplication Tables";

            Console.WriteLine("What times table do you need?");
            int result = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                int number = result * i;
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
