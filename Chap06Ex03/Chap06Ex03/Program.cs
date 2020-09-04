using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Chap06Ex03
{
    class Program
    {
        static int SumVals(params int[] vals)//params 参数数组
        {
            int sum = 0;
            foreach(int val in vals)
            {
                sum += val;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = SumVals(1, 4, 6, 2, 6, 293, 34, 35);
            WriteLine($"The summary is {sum}");
            ReadKey();
        }
    }
}
