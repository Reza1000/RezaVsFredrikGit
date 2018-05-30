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
            
            string superstring = "first and second string, without the second string";
            Console.WriteLine(superstring);
            string st1 = "first string";
            string st2 = "yooo hooo git";

            Console.WriteLine(st1 +" "+ st2);
        }


        static void NoGoodMetod()
        {
            int noUse = 0;
        }

        static string TextWrite(string input)
        {
            return input;
        }

        static int Number(int input)
        {
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
