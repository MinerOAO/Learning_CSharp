using static System.Console;
using System;
using static System.Convert;

namespace Chap05Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortresult, shortval = 4;
            int integerval = 67;
            long longresult;
            float floatval = 10.5f;
            double doubleval = 99.999;
            string stringresult, stringval = "17";
            bool boolval = true;

            shortresult = (short)floatval;
            stringresult = Convert.ToString(boolval) + Convert.ToString(doubleval);
            longresult = integerval + ToInt64(stringval);
            WriteLine($"Variable Conversion Examples:\n{floatval * shortval}");
            WriteLine($"{shortresult},{stringresult},{longresult}");
            ReadKey();

        }
    }
}
