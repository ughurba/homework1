using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.a ededi 1 - reqemlidirse cavabda 1 - reqemli
            // 2 - reqemlidise cavabda 2reqemli.....
            // 5 - reqemlidise cavabda 5reqemli cap edin
            int a = 12;
            if (a >= 0 && a < 10)
            {
                Console.WriteLine("1 - reqemlidir");

            }
            else if (a >= 10 && a < 100)
            {
                Console.WriteLine("2reqemlidir");
            }
            else if (a >= 10000 && a < 100000)
            {
                Console.WriteLine(" 5 - reqemlidir");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
