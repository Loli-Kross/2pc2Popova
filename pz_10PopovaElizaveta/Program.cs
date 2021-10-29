using System;

namespace pz_10PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = random.Next(2, 30);
            int i;
            int s = 0;
            int c = 0;
            int[] F = new int[4];
            int[][] A = new int[2][];
            A[0] = new int [5];
            A[1] = new int[a];
            for (i = 0; i < A[0].Length; i++)
            {
               
                A[0] [i] = random.Next(40);
                Console.Write($"{A[0][i]} ");
                F[0] = A[0][A[0].Length - 1];
            } 
            c = A[0][0];
            int max = A[0][0];
            for (i = 1; i < A[0].Length; i++)
            {
                if (max < A[0][i])
                {
                    max = A[0][i];
                    s = i;
                }
            }
            
            F[2] = max;
            A[0][0] = max;
            A[0][s] = c;
            
            Console.WriteLine();
            for (i = 0; i < A[1].Length; i++)
            {
                A[1] [i] = random.Next(40);
                Console.Write($"{A[1][i]} ");
                F[1] = A[1][A[1].Length - 1];
            }
            c = A[1][0];
            for (i = 1; i < A[1].Length; i++)
            {
                if (max < A[1][i])
                {
                    max = A[1][i];
                    s = i;
                }
            }
            F[3] = max;
            A[1][0] = max;
            A[1][s] = c;
            
            Console.WriteLine();
            Console.Write($"Последние элементы: {F[0]}, {F[1]}\nМаксимальные значения: {F[2]}, {F[3]}");
            Console.WriteLine();
            for (i = 0; i < A[0].Length; i++)
            {
                Console.Write($"{A[0][i]} ");
            }
            Console.WriteLine();
            for (i = 0; i < A[1].Length; i++)
            {
                Console.Write($"{A[1][i]} ");
            }
        }
    }
}
