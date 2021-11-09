using System;

namespace pz_11PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int i, j;
            char[] D = new char[a.Length];
            for  (j = 0; j < D.Length; j++)
            {
                for (i = 0; i < a.Length; i++) 
                {
                    D[j] = a[i];
                    if (Char.IsNumber(D[j]) == true)
                    {
                        Console.WriteLine(D[j]);
                    }
                }
                break;
            }
            
        }
    }
}
