using System;
using System.Timers;

struct MARSH
{
    public string BEGST;
    public string TERM;
    public int NUMER;
    public MARSH(string b, string t, int n)
    {
        BEGST = b;
        TERM = t;
        NUMER = n;
    }
    public override string ToString()
    {
        return $"Начало маршрута {BEGST}\nКонец маршрута {TERM}  \nНомер маршрута {NUMER}";//Вывод данных
    }
}

namespace pz_2_10PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            string Begst;
            string Term;
            
            MARSH[] Marsh = new MARSH[8];
            for (int i = 0; i < Marsh.Length; i++)
            {
                Console.Write("Начало маршрута в точке: ");
                Marsh[i].BEGST = Console.ReadLine();
                Console.Write("Конец маршрута в точке: ");
                Marsh[i].TERM = Console.ReadLine();
                Console.Write("Номер маршрута: ");
                Marsh[i].NUMER = Convert.ToInt16(Console.ReadLine());
                
                Console.WriteLine();
            }
            Console.Write("Введите название точки отправления: ");
            string v = Console.ReadLine();
            Console.WriteLine($"Найденные маршруты:\n");
            for (int i = 0; i < Marsh.Length; i++)
            {
                Begst = Marsh[i].BEGST;
                Term = Marsh[i].TERM;
                if ((v == Begst)|(v== Term))
                {
                    Console.WriteLine(Marsh[i]);
                }
                Console.WriteLine();
            }
            
        }
    }
    
}