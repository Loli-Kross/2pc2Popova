using System;
using System.IO;

namespace pz_17PopovaElizaveta
{
    class Program
    {
        static void Main()
        {
            string g = "";
            Mani(g);
        }
        static string Mani(string f)
        {
            f = @"C:\Windows";
            Console.WriteLine("Подкаталоги:");
            string[] S = Directory.GetDirectories(f);
            foreach (string a in S)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Файлы:");
            string[] P = Directory.GetFiles(f
                );
            foreach (string a in P)
            {
                Console.WriteLine(a);
            }
            return "";
        }
    }
}
