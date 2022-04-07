using System;

namespace _2_8_Delegats
//2.Напишите программу, в которой объявляется делегат для методов с
//символьным аргументом, не возвращающих результат.Опишите класс, в
//котором должно быть символьное поле и метод, позволяющий присвоить
//значение символьному полю объекта. У метода один символьный аргумент и
//метод не возвращает результат. Создайте массив объектов данного класса.
//Создайте экземпляр делегата.В список вызовов этого делегата необходимо
//добавить ссылки на метод (присваивающий значение символьному полю)
//каждого объекта из массива. Проверить результат вызова такого экземпляра
//делегата.
{
    delegate void Symbol(char c);

    class MyClass
    {
        public char myField;

        public void MyMethod(char c)
        {
            myField = c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var array = new MyClass[3] { new MyClass(), new MyClass(), new MyClass() };
            Symbol del = null;
            foreach (var item in array)
            {
                del += item.MyMethod;
            }
            char c = 'o';
            del(c);
            foreach (var item in array)
            {
                Console.WriteLine(item.myField);
            }
            Console.ReadKey();
        }
    }
}