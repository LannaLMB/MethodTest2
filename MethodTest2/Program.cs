using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetIntegers(5, 4);
        }
         public static int GetIntegers(int x, int y)
        {
            int result = 1;
            int input;


            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("That is Not an Integer!  Please Enter an Integer:  ");
            }

            for (int i = 0; i < input; i++)
            {

                result = result * input;
                Console.WriteLine("The Result is " + result);
            }
            return result;
        }
        }

    }
