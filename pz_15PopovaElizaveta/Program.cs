using System;
using System.IO;

namespace pz_15PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\SomeDir3\inFile.txt"))
            {
                string line;
                string[] str;
                int sum = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    sum++;
                }
                Console.WriteLine("Количество строк: " + sum);
            }
            Console.WriteLine();
            using (StreamReader reader1 = new StreamReader(@"C:\SomeDir3\inFile.txt"))
            {
                string line;
                string[] str;
                int sum = 0;
                while ((line = reader1.ReadLine()) != null)
                {
                    sum++;
                    str = line.Split(' ');
                    Console.WriteLine($"Количество слов в {sum} строке: " + str.Length);
                    Console.WriteLine($"Количество символов в {sum} строке: " + line.Length);
                    Console.WriteLine();
                }
            }
        }
    }
}
