using System;

namespace pz_2_12PopovaElizaveta
{
    internal class Program
    {
        string Nik {get; set;}
        string Pochta {get; set;}
        string Password {get; set;}
        int Reting {get; set;}

        public Program()
        {
            Console.WriteLine("Нет данных");
        }
        public Program(string a)
        {
            Nik = a;
            Console.WriteLine($"Никнейм:{Nik}\nПочта: -\nПароль: -\nРейтинг: -");
        }
        public Program(string a, string f)
        {
            Nik = a;
            Pochta = f;
            Console.WriteLine($"Никнейм:{Nik}\nПочта: {Pochta}\nПароль: -\nРейтинг: -");
        }
        public Program(string a, string f, string p)
        {
            Nik = a;
            Pochta = f;
            Password = p;
            Console.WriteLine($"Никнейм:{Nik}\nПочта: {Pochta}\nПароль: {Password}\nРейтинг: -");
        }
        public Program(string a, string f, string p, int g)
        {
            Nik = a;
            Pochta = f;
            Password = p;
            Reting = g;
            Console.WriteLine($"Никнейм:{Nik}\nПочта: -\nПароль: {Password}\nРейтинг: {Reting}");
        }
        public static void GetInfo()
        {

        }

        static void Main(string[] args)
        {
            
        }
    }
}
