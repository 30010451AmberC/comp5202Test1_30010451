using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amber_Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a +ve or -ve value for n:");
            float n = float.Parse(Console.ReadLine());
            Console.Write("Enter a +ve or -ve value for m:");
            float m = float.Parse(Console.ReadLine());

            float c = n * m;
            float b = n + m;

            if (b > 0 && c > 0 )
            {
                Console.WriteLine("That in standard form is : x^2 +" + b + "x" + " " + "+" + c);
            } else if (b > 0)
            {
                Console.WriteLine("That in standard form is : x^2 +" + b + "x" + " " + c);
            } else if (b < 0 && c < 0 )
            {
                Console.WriteLine("That in standard form is : x^2 " + b + "x" + " " + c);
            }
            else
            {
                Console.WriteLine("That in standard form is : x^2 " + b + "x" + " " + "+" + c);
            }
            Console.ReadLine();
        }
    }
}
