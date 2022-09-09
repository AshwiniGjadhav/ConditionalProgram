using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalProgram
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int n = -10;

            if (n > 0)
            {
                Console.WriteLine("NUMBER IS  +VE");
            }
            else if (n < 0)
            {
                Console.WriteLine("NUMBER IS -VE");
            }
            else {
                Console.WriteLine("NUMBER IS ZERO");
            }
        }   
    }
}
