using System;

namespace pz_2._3PopovaElizaveta
{
    class Atom
    {
        static void Main(string[] args)
        {
            //создаём объекты
            Atom atom1 = new Atom("Водород");
            atom1.GetInfo();
            atom1.Valence();
            Atom atom2 = new Atom(5, 10.811f);
            atom2.GetInfo();
            atom2.Valence();
            Atom atom3 = new Atom("Неон", 10, 20.179f);
            atom3.GetInfo();
            atom3.Valence();
            Atom atom4 = new Atom("Фтор", 9);
            atom4.GetInfo();
            atom4.Valence();
            Atom atom5 = new Atom("Берилий");
            atom5.GetInfo();
            atom5.Valence();
            Atom atom6 = new Atom(5);
            atom6.GetInfo();
            atom6.Valence();
            Console.WriteLine($"Количество химических элементов с 1 валентностью: {valenceOne}\nКоличество химических элементов со 2 валентностью: {valenceTwo}");
        }
        //создаём поля, перечисления и методы
        private string name;
        public string Name {get {return "Элемент не выбран";} set {name = value;}}
        private int elementNumber;
        public int ElementNumber {get{return 0;} set{elementNumber = value;}}
        private float mass{get; set;} = 0;
        public int NumberOfElectrons {get {return 0;} set {elementNumber = value;}}
        string valence;
        enum Val 
        {zero, one, two, three, four, five}
        public static int valOne = 1;
        public static int valTwo = 2;
        static int valenceOne;
        static int valenceTwo;
        //создаём метод для вычисления количества элементов 1 или 2 валентности
        public void Valence()
        {
            if (valence == Convert.ToString(valOne))
            {
                valenceOne++;
            } else if (valence == Convert.ToString(valTwo))
            {
                valenceTwo++;
            }
        }
        public Atom(string s) {name = s;}
        public Atom(int c) {elementNumber = c;}
        public Atom(float m) {mass = m;}
        public Atom(string s, int c) {name = s; elementNumber = c;}
        public Atom(string s, float m) {name = s; mass = m;}
        public Atom(int c, float m) {elementNumber = c; mass = m;}
        public Atom(string s, int c, float m) {name = s; elementNumber = c; mass = m;}
        public void GetInfo()
        {
            //прописываем условия для валентности (для первых 10 элементов таблицы, для остальных будет 0)
            if ((name == "Водород")|(name == "Литий")|(name == "Фтор")|(elementNumber == 1)|(elementNumber == 3) | (elementNumber == 9))
            {
                valence = $"{(int)Val.one}";
                Console.WriteLine($"Название: {name}\nНомер элемента: {elementNumber}\nМасса: {mass}\nВалентность: {valence}\nКоличество электронов: {elementNumber}");
            } else if ((name == "Гелий") | (name == "Неон") | (elementNumber == 2) | (elementNumber == 10))
            {
                valence = $"{(int)Val.zero}";
                Console.WriteLine($"Название: {name}\nНомер элемента: {elementNumber}\nМасса: {mass}\nВалентность: {valence}\nКоличество электронов: {elementNumber}");
            } else if ((name == "Берилий") | (name == "Кислород") | (elementNumber == 4) | (elementNumber == 8))
            {
                valence = $"{(int)Val.two}";
                Console.WriteLine($"Название: {name}\nНомер элемента: {elementNumber}\nМасса: {mass}\nВалентность: {valence}\nКоличество электронов: {elementNumber}");
            } else if ((name == "Бор") | (elementNumber == 5))
            {
                valence = $"{(int)Val.three}";
                Console.WriteLine($"Название: {name}\nНомер элемента: {elementNumber}\nМасса: {mass}\nВалентность: {valence}\nКоличество электронов: {elementNumber}");
            } else if ((name == "Углерод") | (elementNumber == 6))
            {
                valence = $"{(int)Val.four}, {(int)Val.two}";
                Console.WriteLine($"Название: {name}\nНомер элемента: {elementNumber}\nМасса: {mass}\nВалентность: {valence}\nКоличество электронов: {elementNumber}");
            } else if ((name == "Азот") | (elementNumber == 7))
            {
                valence = $"{(int)Val.one}, {(int)Val.two}, {(int)Val.three}, {(int)Val.four}";
                Console.WriteLine($"Название: {name}\nНомер элемента: {elementNumber}\nМасса: {mass}\nВалентность: {valence}\nКоличество электронов: {elementNumber}");
            }
        }
    }
}
        //public string Name {
        //    get {return name = "Элемент не выбран";} 
        //    set{ 
        //        name = Console.ReadLine();
        //        switch (name)
        //        {
        //            case "Водород": countElectrons = 1; numberOfElectrons = 1; mass = 1.00794f; valence = Convert.ToChar(Val.I); break;
        //            case "Гелий": countElectrons = 2; numberOfElectrons = 2; mass = 4.002602f; valence = Convert.ToChar(Val._); break;
        //            case "Литий": countElectrons = 3; numberOfElectrons = 3; mass = 6.941f; valence = Convert.ToChar(Val.I); break;
        //            case "Берилий": countElectrons = 4; numberOfElectrons = 4; mass = 9.012182f; valence = Convert.ToChar(Val.II); break;
        //            case "Бор": countElectrons = 5; numberOfElectrons = 5; mass = 10.811f; valence = Convert.ToChar(Val.III); break;
        //            case "Углерод": countElectrons = 6; numberOfElectrons = 6; mass = 12.0107f; valence = Convert.ToChar($"{Val.IV}, {Val.II}"); break;
        //            case "Азот": countElectrons = 7; numberOfElectrons = 7; mass = 14.0067f; valence = Convert.ToChar($"{Val.I}, {Val.II}, {Val.III}, {Val.IV}"); break;
        //            case "Кислород": countElectrons = 8; numberOfElectrons = 8; mass = 15.9994f; valence = Convert.ToChar(Val.II); break;
        //            case "Фтор": countElectrons = 9; numberOfElectrons = 9; mass = 18.9984032f; valence = Convert.ToChar(Val.I); break;
        //            case "Неон": countElectrons = 10; numberOfElectrons = 10; mass = 20.1797f; valence = Convert.ToChar(Val._); break;
        //        }
        //    }
        //} 
        //public int CountElectrons {
        //    get {return countElectrons = 0;}
        //    set 
        //    {
        //        countElectrons = Console.Read();
        //        switch (countElectrons) 
        //        { 
        //            case 1: name = "Водород"; numberOfElectrons = 1; mass = 1.00794f; valence = Convert.ToChar(Val.I); break;
        //            case 2: name = "Гелий"; numberOfElectrons = 2; mass = 4.002602f; valence = Convert.ToChar(Val._); break;
        //            case 3: name = "Литий"; numberOfElectrons = 3; mass = 6.941f; valence = Convert.ToChar(Val.I); break;
        //            case 4: name = "Берилий"; numberOfElectrons = 4; mass = 9.012182f; valence = Convert.ToChar(Val.II); break;
        //            case 5: name = "Бор"; numberOfElectrons = 5; mass = 10.811f; valence = Convert.ToChar(Val.III); break;
        //            case 6: name = "Углерод"; numberOfElectrons = 6; mass = 12.0107f; valence = Convert.ToChar($"{Val.IV}, {Val.II}"); break;
        //            case 7: name = "Азот"; numberOfElectrons = 7; mass = 14.0067f; valence = Convert.ToChar($"{Val.I}, {Val.II}, {Val.III}, {Val.IV}"); break;
        //            case 8: name = "Кислород"; numberOfElectrons = 8; mass = 15.9994f; valence = Convert.ToChar(Val.II); break;
        //            case 9: name = "Фтор"; numberOfElectrons = 9; mass = 18.9984032f; valence = Convert.ToChar(Val.I); break;
        //            case 10: name = "Неон"; numberOfElectrons = 10; mass = 20.1797f; valence = Convert.ToChar(Val._); break;
        //        }
        //    }
        //}
        //public float Mass { 
        //    get {return mass = 0;} 
        //    set
        //    {
        //        mass = Console.Read();
        //        switch (mass)
        //        {
        //            case 1.00794f: name = "Водород"; countElectrons = 1; numberOfElectrons = 1; valence = Convert.ToChar(Val.I); break;
        //            case 4.002602f: name = "Гелий"; countElectrons = 1; numberOfElectrons = 2; valence = Convert.ToChar(Val._); break;
        //            case 6.941f: name = "Литий"; countElectrons = 1; numberOfElectrons = 3; valence = Convert.ToChar(Val.I); break;
        //            case 9.012182f: name = "Берилий"; countElectrons = 1; numberOfElectrons = 4; valence = Convert.ToChar(Val.II); break;
        //            case 10.811f: name = "Бор"; countElectrons = 1; numberOfElectrons = 5; valence = Convert.ToChar(Val.III); break;
        //            case 12.0107f: name = "Углерод"; countElectrons = 1; numberOfElectrons = 6; valence = Convert.ToChar($"{Val.IV}, {Val.II}"); break;
        //            case 14.0067f: name = "Азот"; countElectrons = 1; numberOfElectrons = 7; valence = Convert.ToChar($"{Val.I}, {Val.II}, {Val.III}, {Val.IV}"); break;
        //            case 15.9994f: name = "Кислород"; countElectrons = 1; numberOfElectrons = 8; valence = Convert.ToChar(Val.II); break;
        //            case 18.9984032f: name = "Фтор"; countElectrons = 1; numberOfElectrons = 9; valence = Convert.ToChar(Val.I); break;
        //            case 20.1797f: name = "Неон"; countElectrons = 1; numberOfElectrons = 10; valence = Convert.ToChar(Val._); break;
        //        }
        //    }
        //}