using System;

namespace pz_12PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string a = Console.ReadLine();
            string[] A = a.Split(' ');
            for (i = 0; i < A.Length; i++)
            {
                if (A[i].Contains('@'))
                {
                    Console.WriteLine(A[i]);
                }
            }
        }
    }
}
