using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static int Ackermann(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (m > 0 && n == 0)
                return Ackermann(m - 1, 1);
            else if (m > 0 && n > 0)
                return Ackermann(m - 1, Ackermann(m, n - 1));
            else
                throw new Exception("Ackermann shouldn't be partial... Fix yourself.");
        }

        static int Ackermann_imp(int m, int n)
        {
            var depth = 0;

            do
            {
                if (m == 0)
                {
                    n++;

                    if (n == 0)
                        break;
                }
                else if (m > 0 && n == 0)
                {
                    ;
                }
                else if (m > 0 && n > 0)
                {
                    ;
                }
            } while (m != 0);

            return n;

            throw new Exception("Ackermann shouldn't be partial... Fix yourself.");
        }

        static void Main(string[] args)
        {
            Console.Write($"{Ackermann(0, 2)} =?= ");
            Console.WriteLine($"{Ackermann_imp(0, 2)}");
        }
    }
}
