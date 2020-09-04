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
            string[] friendnames = { "Andy", "Kevin", "Holton" };
            int i = 0,j = friendnames.Length;
            Console.WriteLine($"Here are {j} of my friend{(j > 1 ? "s ":" ")}:");
            for(;i<j;++i)
            {
                Console.WriteLine(friendnames[i]);
            }
            Console.ReadKey();
        }
    }
}
