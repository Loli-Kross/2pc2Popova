using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 1;
            while (b < 10) 
            {
                Console.WriteLine($"{a}*{b}=" + a*b);
                b++;
            }
        }
    }
}
