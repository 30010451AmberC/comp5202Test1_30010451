using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number between 1 and 1000:");
            int num = int.Parse(Console.ReadLine());

            if (num%2 == 0)
            {
                Console.WriteLine("That number is even");
            }
            else
            {
                Console.WriteLine("That number is odd");
            }
            Console.ReadLine();
        }
    }
}
