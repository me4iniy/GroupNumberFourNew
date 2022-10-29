using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupNumberFourNew
{
    public class AllIntegersFromTo
    {
        public void PrintIntegers(int a, int b, int c)
        {
            for (var i = a; i < b; i++)
                if (i % c == 0)
                    Console.WriteLine(i);
        }
    }
}
