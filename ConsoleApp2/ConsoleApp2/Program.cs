using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            int[] number = { 0b0001_0000, 0b0010_0000, 0b0000_0010 };
            string myString;
            myInteger = 17;
            myString = "\"myString\" is ";
            Console.WriteLine($"{myString}{number[0]}");
            Console.ReadKey();

        }
    }
}
