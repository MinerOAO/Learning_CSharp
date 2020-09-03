#region directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
#endregion
namespace Chap04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int interger;
            bool test;
            WriteLine("Please enter a interger:");
            interger = ToInt32(ReadLine());
            test = interger > 10;
            if (test == false)
                WriteLine("True!");
            else
                WriteLine("False !");
            ReadKey();
        }
    }
}
