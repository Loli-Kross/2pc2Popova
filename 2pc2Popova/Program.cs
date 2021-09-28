using System;

namespace _2pc2Popova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            float i;
            for (i = 20; i <= 90; i += 5)
                Console.WriteLine(i.ToString());
            Console.WriteLine("Задание №2");
            char s1 = 'Ж';
            for(var  s = 0 ; s < 5; s++ )
            {
                Console.WriteLine(s1);
                s1++;
            }
            Console.WriteLine();
                Console.WriteLine("Задание №3");
            for (var a = 0; a < 8; a++)
            {
                for (var j = 0; j < 7; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задание №4");
            for (int u = 0; u <= 100; u++)
                if (u % 13 == 0) Console.WriteLine(u);
            Console.WriteLine("Задание №5");
            for (int r = 5, t = 100; Math.Abs(r-t)!= 9; r++, t--)
            {
                Console.WriteLine(" {0} {1} ", r, t);
            }
        }
    }
}
