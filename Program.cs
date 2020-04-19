using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring data
            int n = 0, p = 0, v = 0;

            //Requesting data from the user
            Console.Write(" Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the posicion: ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the value 0 o 1: ");
            v = Convert.ToInt32(Console.ReadLine());
            int i = 1, move = 0;

            // Moving 1 to the given position
            move = i << (p - 1);

            //Transforming the position with the desired value
            if ((n & move) == 0)
            {
                if (v == 1)
                {
                    Console.WriteLine(n | move);
                }
                else

                {
                    Console.WriteLine(n);
                }
            }
            else
            {
                if (v == 0)
                {
                    Console.WriteLine(n & (~move));
                }
                else
                {
                    Console.WriteLine(n);
                }
            
            }
            Console.ReadKey();
        }
    }
}
