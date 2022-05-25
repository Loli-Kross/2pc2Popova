using System;

namespace pz_2._3PopovaElizaveta
{
    class Atom
    {
        static void Main(string[] args)
        {
            //создаём объекты
            Atom atom1 = new RadioactiveAtom("Водород");
            atom1.GetInfo();
            atom1.Valence();
            Atom atom2 = new RadioactiveAtom(5, 10.811f);
            atom2.GetInfo();
            atom2.Valence();
            Atom atom3 = new RadioactiveAtom("Неон", 10, 20.179f);
            atom3.GetInfo();
            atom3.Valence();
            Atom atom4 = new RadioactiveAtom("Фтор", 9);
            atom4.GetInfo();
            atom4.Valence();
            Atom atom5 = new RadioactiveAtom("Бериллий");
            atom5.GetInfo();
            atom5.Valence();
            Atom atom6 = new RadioactiveAtom(5);
            atom6.GetInfo();
            atom6.Valence();
            Atom atom = new RadioactiveAtom("Водород");
            Console.WriteLine($"Количество химических элементов с 1 валентностью: {valenceOne}\nКоличество химических элементов со 2 валентностью: {valenceTwo}");
        }
        //создаём поля, перечисления, конструкторы и методы
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
                Console.WriteLine($"Название: {name}\nНомер элемента: {elementNumber}\nМасса: {mass}\nВалентность: {valence}\nКоличество электронов: {elementNumber}\nПериод полураспада элемента: ");
            } else if ((name == "Гелий") | (name == "Неон") | (elementNumber == 2) | (elementNumber == 10))
            {
                valence = $"{(int)Val.zero}";
                Console.WriteLine($"Название: {name}\nНомер элемента: {elementNumber}\nМасса: {mass}\nВалентность: {valence}\nКоличество электронов: {elementNumber}");
            } else if ((name == "Бериллий") | (name == "Кислород") | (elementNumber == 4) | (elementNumber == 8))
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
    //создаём подкласс
    class RadioactiveAtom : Atom
    {
        private string halfLife;
        public string HalfLife {
            get {return "0 сек";} 
            set {
                
                if ((Name == "Водород")|(ElementNumber == 1)){halfLife = "12,3 года";} 
                else if((Name == "Гелий")|(ElementNumber == 2)){halfLife = "-";}
                else if ((Name == "Литий")|(ElementNumber == 3)){halfLife = "-";}
                else if ((Name == "Бериллий")|(ElementNumber == 4)){halfLife = "8,2·10-17 сек";}
                else if ((Name == "Бор")|(ElementNumber == 3)){halfLife = "-";}
                else if ((Name == "Углерод")|(ElementNumber == 6)){halfLife = "5700 лет";}
                else if ((Name == "Азот")|(ElementNumber == 7)){halfLife = "10 мин";}
                else if ((Name == "Кислород")|(ElementNumber == 8)){halfLife = "-";}
                else if ((Name == "Фтор")|(ElementNumber == 9)){halfLife = "4.158 сек - 109.771 мин";}
                else if ((Name == "Неон")|(ElementNumber == 10)){halfLife = "-";}
            }
        }
        public RadioactiveAtom(string name) : base(name) { }
        public RadioactiveAtom(int elementNumber) : base(elementNumber) { }
        public RadioactiveAtom(float mass) : base(mass) { }
        public RadioactiveAtom(string name, int elementNumber) : base(name, elementNumber) { }
        public RadioactiveAtom(string name, float mass) : base(name, mass) { }
        public RadioactiveAtom(int elementNumber, float mass) : base(elementNumber, mass) { }
        public RadioactiveAtom(string name, int elementNumber, float mass) : base(name, elementNumber, mass) { }
        public virtual void Half()
        {
            string c = halfLife;
        }
            //на этом мои познания как и возможности мозговой активности иссякают. Я не могу понять как исправить метод вывода данных в консоль чтобы всё не поломать.
    }
}