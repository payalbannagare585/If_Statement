using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            if (num>=0)
            {
                Console.WriteLine("number is positive");

            }
            else if (num<0)
            {
                Console.WriteLine("number is negative");

            
            }
            else
            {
                Console.WriteLine("number is zero");
            }

        }
    }
}
