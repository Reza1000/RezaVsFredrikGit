using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaVsFredrikGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "first string";
        }


        static void NoGoodMetod()
        {
            int noUse = 0;
        }

        static string TextWrite(string input)
        {
            Console.WriteLine(input);
            return input;
        }

        static int Factorial(int num) {
            if (num <= 0) {
                return 0;
            }
            return num + Factorial(num - 1);
        }
    }
}
