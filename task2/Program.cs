using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.a - ededi 3-e bolunən cüt ədəddirsə "3-e bolunur cutdur" ,
            //3-e bolunən tek ededdirse " 3 - e bolunur tekdir"
            //eks halda "3 - e bolunmur" sözünü ekranda çap edin

            int a = 15;
            int b = a % 3;
            int c = a % 2;


            if (c == 0 && b == 0)
            {
                Console.WriteLine("3-e bolunur cutdur");

            }
            else if (c != 0 && b == 0)
            {
                Console.WriteLine("3 - e bolunur tekdir");
            }
            else
            {

                Console.WriteLine("3 - e bolunmur");
            }
        }
    }
}
