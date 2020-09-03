using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace Chap04Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name_1 = "benjamin";
            const string name_2 = "andrea";
            const string name_3 = "ploopy";
            string input;
            WriteLine("Please enter your name:");
            input = ReadLine();
            switch(input.ToLower())
            {
                case name_1:
                    WriteLine("Same name");
                    break;
                case name_2:
                    WriteLine("Good name");
                    break;
                case name_3:
                    WriteLine("Bad name");
                    break;
            }
            WriteLine($"Hello,{input.ToLower()}!");
            ReadKey();
        }
    }
}
