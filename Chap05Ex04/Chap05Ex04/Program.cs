using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendnames_1 = { "Andy", "Kevin", "Holton" };
            string[] friendnames_2 = { "Tsunomaki Watame" };
            int i = 0,j = friendnames_1.Length;
            Console.WriteLine($"Here {(j > 1 ? $"are {j} of my friends" : "is 1 of my friend")}");
            for(;i<j;++i)
            {
                Console.WriteLine(friendnames_1[i]);
            }
            j = friendnames_2.Length;
            Console.WriteLine($"Here {(j > 1 ? $"are {j} of my friends" : "is 1 of my friend")}");
            foreach(string name in friendnames_2)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
