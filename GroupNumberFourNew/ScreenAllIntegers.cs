using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupNumberFourNew
{
    public class ScreenAllIntegers
    {
        public static void PrintIntegers()
        {
            for (int i = 100; i < 201; i++)
                if (i % 3 == 0)
                    Console.WriteLine(i);
        }
    }
}
