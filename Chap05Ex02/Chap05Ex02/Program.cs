namespace Chap05Ex02
{
    //枚举enum
    enum orient_1 : byte//指定基本类型，默认为int,可设为s/byte,u/short,u/int,u/long
    {
        north = 1,//可指定，默认为0
        south = 2,
        east = 3,
        west = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            orient_1 dir_orient = orient_1.south;
            System.Console.WriteLine($"Direction:{dir_orient}");
            System.Console.ReadKey();
        }
    }
}
