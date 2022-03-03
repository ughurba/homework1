using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.a ve b ededinin cemi 2-reqemlidirse "cem ikireqemli ededdir"
            //cem 3 reqemlidirse "cem ucreqemlidir"
            //eks halda "nezere alinmayıb" cap edilsin

            int a = 10;
            int b = 1;
            int c = a + b;
            if (c > 9 && c < 100)
            {
                Console.WriteLine($"{c} ikireqemli ededdir");
            }
            else if (c > 100 && c < 1000)
            {
                Console.WriteLine($"{c} ucreqemlidir");
            }
            else
            {
                Console.WriteLine("nezere alinmayib");
            }
        }
    }
}
