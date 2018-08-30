using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                total = total + int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the average of those 10 numbers is: " + (total / 10));
            Console.ReadLine();
        }
    }
}
