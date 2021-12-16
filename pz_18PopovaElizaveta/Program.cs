using System;
using System.IO;

namespace pz_18PopovaElizaveta
{
    class Program
    {
        static int Mai(int n)
        {
            if (n < 1) return 0;
            else if (n == 1) return 50;
            return Mai(n)+3;
        }
        static void Main()
        {
            int n = Console.Read();
            Mai(n);
        }
    }
}
//a[n] = a[n-1] + d