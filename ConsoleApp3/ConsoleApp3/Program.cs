#region directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1, Num2;
            Console.WriteLine("Please enter number_1:");
            Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter number_2:");
            Num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{Num1},{Num2}");
            Console.ReadKey();
        }
    }
}
