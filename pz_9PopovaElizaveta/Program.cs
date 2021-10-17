using System;

namespace pz_9PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] A = new int [n, n];
            int i, j;
            Random random = new Random();
            for (i = 0; i <=(n-1); i++)
            {
                for (j = 0; j <=(n-1); j++)
                {
                    A[i, j] = random.Next(1,10);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            int f = 1;
            int h = 0;
            bool r;
            for (i = 1; i <=(n-1); i++)
            {
                for (j = 1; j <=(n-1); j++)
                {
                    do
                    {
                        r = f.Equals(A[i, j]);
                        if (r == true)
                        {
                            Console.WriteLine(f);
                            break;
                        }
                        else
                        {
                            h++;
                        }
                    }  
                    while (i == n - j + h);

                }
            }
            
            //for (int s = 1; s <=10; s++)
            //{

            
            //    for (i = 1; i <= (n - 1); i++)

            //    {
                
            //        for (j = 1; j <= (n - 1); j++)
            //        {
            //            int k = 0;
            //            if ((i <= n - j + k) & (s == A[i, j]))
            //            {
            //                Console.Write(s);
                        
            //                break;
                        
            //            } else
            //            {
            //                k++;

            //            }
            //        }
            //    }
            //}
        }
    }
}
