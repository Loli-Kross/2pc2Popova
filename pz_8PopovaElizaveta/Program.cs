using System;
using System.Linq;

namespace pz_8PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i, j;
            int a = j = 0;
            int[] F = new int[10];
            int[] A = new int[10];
            Random random = new Random();
            for (i = 0; i < A.Length; i++)
            {
                    A[i] = random.Next(-20, 20);
                    Console.Write($"{A[i]} ");
                    if (A[i]<0)
                    {
                        a++;
                    }
            }
            Console.WriteLine();
            Console.Write(a);
            Console.WriteLine();
            for (j = 0; j < F.Length; j++)
            {
                for (i = 0; i < A.Length; i++)
                {
                    if (A[i]<0)
                    {
                        F[j]=A[i];
                        Console.Write($"{F[j]}");
                    }
                }
                break;
            }
            for (j = 0; j < F.Length; j++)
            {
                int current = F[j];
                int k = j-1;
                while (k >= 0 && current > F[k])
                {
                    F[k+1] = F[k];
                    k--;
                }
                F[k+1] = current;
            }
            Console.WriteLine();
            foreach (var VARIABLE in F)
            {
                Console.Write(" " + VARIABLE);
            }
            
            
            //var outArr = A.Distinct();
            //foreach (int x in outArr) Console.Write($"{x}\t");
        }
    }
}
