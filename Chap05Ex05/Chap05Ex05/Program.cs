using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chap05Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pattern Matching
            string[] friendnames = { "Todd Anthony", "Kevin Holton", "Shane Laigle", null, "" };
            foreach (var name in friendnames)//var
            {
                switch (name)
                {
                    case string t when t.StartsWith("T"):
                        WriteLine($"This friend name starts with a 'T',{name}");
                        break;
                    case string e when e.Length==0://when语句附加条件
                        WriteLine("No value");
                        break;
                    case null:
                        WriteLine("NULL value");
                        break;
                    case var x://任意其他类型
                        WriteLine($"This is a {x.GetType().Name}");
                        break;
                    default:
                        break;
                }
             

            }
            #endregion
            int sum = 0, total = 0, counter = 0, intvalue = 0;
            int?[] myintarray = new int?[7] { 5, intvalue, 9, 10, null, 2, 99 };//?使int数组可包含空对象
            foreach (var integer in myintarray)
            {
                switch(integer)
                {
                    case 0:
                        WriteLine($"Integer number'{total}' has a value of 0");
                        ++total;
                        break;
                    case int value:
                        ++counter;++total;sum += value;
                        WriteLine($"Integer number'{total}' has a value of {value}");
                        break;
                    case null:
                        WriteLine($"Integer number'{total}' is null");
                        ++total;
                        break;
                    default:
                        break;
                }
            }
            WriteLine($"There are {total} integers.{counter} of them got values.The sum of them is {sum}. ");
            ReadKey();
        }
    }
}
