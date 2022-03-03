using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. a ededi b ededine tam bolunurse tam bolunur eks halda bolunmur
            int a = 9;
            int b = 3;

            if (a % b == 0)
            {
                Console.WriteLine("doqrudur");
            }
            else
            {
                Console.WriteLine("sefdir");
            }
        }
    }
}
