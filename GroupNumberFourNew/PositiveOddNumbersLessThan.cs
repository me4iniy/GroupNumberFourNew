using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupNumberFourNew
{
    public class PositiveOddNumbersLessThan
    {
        public static void PositiveOddNumbersLessThanResult()
        {
            int sumOddNumber = 0;

            for (int i = 0; i < 50; i++)
                if (i % 2 != 0)
                    sumOddNumber += sumOddNumber + i;

            Console.WriteLine(sumOddNumber);
        }
    }
}
