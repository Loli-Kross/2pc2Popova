using System;

namespace pz_10_PopovaElizaveta
{
    struct MARSH
    {
        string BEGST;
        string TERM;
        int NUMER;
        public MARSH(string b, string t, int n) //конструктор структуры
        {
            BEGST = b;
            TERM = t;
            NUMER = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MARSH[] TRAFIC = new MARSH[8];
            MARSH a = new MARSH("Наклонная", "Правовая", 1);
            MARSH b = new MARSH("Наклонная", "Калина", 2);
            MARSH с = new MARSH("Правовая", "Калина", 3);
            MARSH d = new MARSH("Хакова", "Правовая", 4);
            MARSH e = new MARSH("Хакова", "Наклонная", 5);
            MARSH f = new MARSH("Калина", "Проездная", 6);
            MARSH g = new MARSH("Проездная", "Наклонная", 7);
            MARSH h = new MARSH("Калина", "Хакова", 8);
            for (int i = 0; i<TRAFIC.Length; i++)
            {
                
            }
        }
    }
}
