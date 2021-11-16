using System;

namespace pz_13PopovaElizaveta
{
    class Program
    { 
        enum Grade {очень_плохо = 1, неудовлетворительно, удовлетворительно, хорошо, отлично};
        static void Main(string[] args)
        {
            Console.WriteLine("Введите оценку:");
            int v;
            v = Convert.ToInt32(Console.Read());
            switch (v)
            {
                case (int)Grade.очень_плохо: Console.WriteLine($"Характеристика отметки {v}: очень_плохо");
                    break;
                case (int)Grade.неудовлетворительно: Console.WriteLine($"Характеристика отметки {v}: неудовлетворительно");
                    break;
                case (int)Grade.удовлетворительно: Console.WriteLine($"Характеристика отметки {v}: удовлетворительно");
                    break;
                case (int)Grade.хорошо: Console.WriteLine($"Характеристика отметки {v}: хорошо");
                    break;
                case(int) Grade.отлично: Console.WriteLine($"Характеристика отметки {v}: отлично");
                    break;
            }
        }
    }
}
