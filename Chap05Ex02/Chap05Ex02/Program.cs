using static System.Console;
using static System.Convert;
namespace Chap05Ex02
{
    //枚举enum
    enum orient : byte//指定基本类型，默认为int,可设为s/byte,u/short,u/int,u/long
    {
        north = 1,//可指定，默认为0
        south = 2,
        east = 3,
        west = 4
    }
    struct route
    {
        public orient direction;
        public float distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            route myroute;
            float distance = -1;
            int direction = -1;
            do
            {
                WriteLine("Select a direction:");
                direction = ToInt32(ReadLine());
            }while (direction < 1 || direction > 4);

            do
            {
                WriteLine("Enter distance:");
                distance = ToSingle(ReadLine());
            }while (distance < 0);
            myroute.distance = distance;
            myroute.direction = (orient)direction;
            WriteLine($"Direction:{myroute.direction} Distance:{myroute.distance}");
            ReadKey();
        }
    }
}
