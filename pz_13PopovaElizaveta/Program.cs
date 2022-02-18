using System;

namespace pz_13PopovaElizaveta
{
    class Program
    { 
        enum Grade {очень_плохо, неудовлетворительно, удовлетворительно, хорошо, отлично};
        static void Main()
        {
            Console.WriteLine("Введите оценку:");
            int v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1: 
                    Console.WriteLine($"Характеристика отметки 1: {Grade.очень_плохо}");
                    break;
                case 2: 
                    Console.WriteLine($"Характеристика отметки 2: {Grade.неудовлетворительно}");
                    break;
                case 3: 
                    Console.WriteLine($"Характеристика отметки 3: {Grade.удовлетворительно}");
                    break;
                case 4: 
                    Console.WriteLine($"Характеристика отметки 4: {Grade.хорошо}");
                    break;
                case 5: 
                    Console.WriteLine($"Характеристика отметки 5: {Grade.отлично}");
                    break;
                default:
                    Console.WriteLine("Неверное значение оценки");
                    break;
            }
        }
    }
}
