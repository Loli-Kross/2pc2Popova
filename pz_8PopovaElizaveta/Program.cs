using System;

namespace pz_8PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleKeyInfo keyInfo;
            int x;
            int[] A = new int[20];
            Random random = new Random();
            A[0] = random.Next(30);
            for (x = 0; x < A.Length; x++)
            {
                while (x <= 19)
                {
                    A[x] = random.Next(30);
                    Console.WriteLine(A[x]);
                    x++;
                }

            }
            for (int i = 1; i < 20;)
            {
                int n = random.Next(30);
                for (x = 0; x < i; x++)
                {
                    if (n == A[x])
                        break; 
                }
                if (x == i)
                { 
                    A[i] = n;
                    i++;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
