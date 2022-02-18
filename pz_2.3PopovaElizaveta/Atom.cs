using System;

namespace pz_2._3PopovaElizaveta
{
    class Atom
    {
        static void Main(string[] args)
        {
            Atom atom1 = new Atom(Console.ReadLine());
            atom1.GetInfo();
            Atom atom2 = new Atom(68, 167.26f);
            atom2.GetInfo();
            Atom atom3 = new Atom("Нептуний", 93, 237.0482f);
            atom3.GetInfo();
        }
        private string name;
        public string Name {
            get {return name = "Элемент не выбран";} 
            set{ 
                name = Console.ReadLine();
                switch (name)
                {
                    case "Водород": countElectrons = 1; numberOfElectrons = 1; mass = 1.00794f; valence = Convert.ToChar(Val.I); break;
                    case "Гелий": countElectrons = 2; numberOfElectrons = 2; mass = 4.002602f; valence = Convert.ToChar(Val._); break;
                    case "Литий": countElectrons = 3; numberOfElectrons = 3; mass = 6.941f; valence = Convert.ToChar(Val.I); break;
                    case "Берилий": countElectrons = 4; numberOfElectrons = 4; mass = 9.012182f; valence = Convert.ToChar(Val.II); break;
                    case "Бор": countElectrons = 5; numberOfElectrons = 5; mass = 10.811f; valence = Convert.ToChar(Val.III); break;
                    case "Углерод": countElectrons = 6; numberOfElectrons = 6; mass = 12.0107f; valence = Convert.ToChar($"{Val.IV}, {Val.II}"); break;
                    case "Азот": countElectrons = 7; numberOfElectrons = 7; mass = 14.0067f; valence = Convert.ToChar($"{Val.I}, {Val.II}, {Val.III}, {Val.IV}"); break;
                    case "Кислород": countElectrons = 8; numberOfElectrons = 8; mass = 15.9994f; valence = Convert.ToChar(Val.II); break;
                    case "Фтор": countElectrons = 9; numberOfElectrons = 9; mass = 18.9984032f; valence = Convert.ToChar(Val.I); break;
                    case "Неон": countElectrons = 10; numberOfElectrons = 10; mass = 20.1797f; valence = Convert.ToChar(Val._); break;
                }
            }
        } 
        private int numberOfElectrons;
        private int countElectrons;
        public int CountElectrons {
            get {return countElectrons = 0;}
            set 
            {
                countElectrons = Console.Read();
                switch (countElectrons) 
                { 
                    case 1: name = "Водород"; numberOfElectrons = 1; mass = 1.00794f; valence = Convert.ToChar(Val.I); break;
                    case 2: name = "Гелий"; numberOfElectrons = 2; mass = 4.002602f; valence = Convert.ToChar(Val._); break;
                    case 3: name = "Литий"; numberOfElectrons = 3; mass = 6.941f; valence = Convert.ToChar(Val.I); break;
                    case 4: name = "Берилий"; numberOfElectrons = 4; mass = 9.012182f; valence = Convert.ToChar(Val.II); break;
                    case 5: name = "Бор"; numberOfElectrons = 5; mass = 10.811f; valence = Convert.ToChar(Val.III); break;
                    case 6: name = "Углерод"; numberOfElectrons = 6; mass = 12.0107f; valence = Convert.ToChar($"{Val.IV}, {Val.II}"); break;
                    case 7: name = "Азот"; numberOfElectrons = 7; mass = 14.0067f; valence = Convert.ToChar($"{Val.I}, {Val.II}, {Val.III}, {Val.IV}"); break;
                    case 8: name = "Кислород"; numberOfElectrons = 8; mass = 15.9994f; valence = Convert.ToChar(Val.II); break;
                    case 9: name = "Фтор"; numberOfElectrons = 9; mass = 18.9984032f; valence = Convert.ToChar(Val.I); break;
                    case 10: name = "Неон"; numberOfElectrons = 10; mass = 20.1797f; valence = Convert.ToChar(Val._); break;
                }
            }
        }
        private float mass;
        public float Mass { 
            get {return mass = 0;} 
            set
            {
                mass = Console.Read();
                switch (mass)
                {
                    case 1.00794f: name = "Водород"; countElectrons = 1; numberOfElectrons = 1; valence = Convert.ToChar(Val.I); break;
                    case 4.002602f: name = "Гелий"; countElectrons = 1; numberOfElectrons = 2; valence = Convert.ToChar(Val._); break;
                    case 6.941f: name = "Литий"; countElectrons = 1; numberOfElectrons = 3; valence = Convert.ToChar(Val.I); break;
                    case 9.012182f: name = "Берилий"; countElectrons = 1; numberOfElectrons = 4; valence = Convert.ToChar(Val.II); break;
                    case 10.811f: name = "Бор"; countElectrons = 1; numberOfElectrons = 5; valence = Convert.ToChar(Val.III); break;
                    case 12.0107f: name = "Углерод"; countElectrons = 1; numberOfElectrons = 6; valence = Convert.ToChar($"{Val.IV}, {Val.II}"); break;
                    case 14.0067f: name = "Азот"; countElectrons = 1; numberOfElectrons = 7; valence = Convert.ToChar($"{Val.I}, {Val.II}, {Val.III}, {Val.IV}"); break;
                    case 15.9994f: name = "Кислород"; countElectrons = 1; numberOfElectrons = 8; valence = Convert.ToChar(Val.II); break;
                    case 18.9984032f: name = "Фтор"; countElectrons = 1; numberOfElectrons = 9; valence = Convert.ToChar(Val.I); break;
                    case 20.1797f: name = "Неон"; countElectrons = 1; numberOfElectrons = 10; valence = Convert.ToChar(Val._); break;
                }
                
            }
        }
        enum Val 
        {
            I = 1, II = 2, III = 3, IV = 4, V = 5, _ = 0
        }
        private char valence;
        public Atom(string s) {Name = s;}
        public Atom(int c) {CountElectrons = c;}
        public Atom(float m) {Mass = m;}
        public Atom(string s, int c) {Name = s; CountElectrons = c;}
        public Atom(string s, float m) {Name = s; Mass = m;}
        public Atom(int c, float m) {CountElectrons = c; Mass = m;}
        public Atom(string s, int c, float m) {Name = s; CountElectrons = c; Mass = m;}
        public void GetInfo()
        {
            Console.WriteLine($"Название: {name}\nПорядковый номер: {countElectrons}\nМасса: {mass}\nВалентность: {valence}\nКоличество электронов: {numberOfElectrons}");
        }
    }
}
