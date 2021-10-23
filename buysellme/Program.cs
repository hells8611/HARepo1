using System;

namespace buysellme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the buy sell me network, i am your server today, my name is Karen");

            Thing one = new Thing("Gold Shoes");
            Console.WriteLine(one.Name);

            one.Name = "Platinum socks";
            Console.WriteLine(one.Name);
        }
    }
}
