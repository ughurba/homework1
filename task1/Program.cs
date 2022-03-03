using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.a - ededi 3-e bolunurse "Yes" ,bölünmürsə "No" sözünü ekranda çap edin

            int a = 13;
            int b = 3;

            if (a % b == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
    }
}
