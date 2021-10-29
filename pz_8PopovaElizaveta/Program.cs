using System;
using System.Linq;

namespace pz_8PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i;
            int[] A = new int[20];
            Random random = new Random();
            for (i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(30);
                Console.Write($"{A[i]} ");
            }
            var outArr = A.Distinct();
            foreach (int x in outArr) Console.Write($"{x}\t");
        }
    }
}
