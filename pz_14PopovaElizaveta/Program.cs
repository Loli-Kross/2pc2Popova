using System;
using System.IO;

namespace pz_14PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int i, j, d;
            d = 0;
            string path = @"C:\SomeDir3\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            using (FileStream inFile = new FileStream($"{path}inFile.txt", FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(a);
                inFile.Write(array, 0, array.Length);
            }
            using (FileStream onFile = File.OpenRead($"{path}inFile.txt"))
            {
                byte[] array = new byte [onFile.Length];
                onFile.Read(array, 0, array.Length);
                string t = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"{t}\n");
                for(i = 0; i < array.Length; i++)
                {
                    for (j = 0; j<array.Length; j++) 
                    { 
                        char s = t[i];
                        if (char.IsNumber(s) == true)
                        {
                            d++;
                        }
                        break;
                    }
                }
                Console.WriteLine($"{d}");
            }
            
        }
    }
}
