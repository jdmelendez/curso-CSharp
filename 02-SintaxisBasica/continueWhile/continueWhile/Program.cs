using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continueWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                i++;
                if (i %2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                                
            }
            Console.ReadKey();
        }
    }
}
