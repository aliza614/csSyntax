using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csSyntaxAndSyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*change to include 
             * 1. inferred typing
             * 2. string interpolation
             * 3. Ternary Operator
            int answer = 4;
            string response;
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " is greater than or equal to nine";
            }
            */
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);
        }
    }
}
