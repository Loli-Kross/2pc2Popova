using System;

namespace od_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите количество элементов массива");
            string n = Console.ReadLine();
            int k = Convert.ToInt32(n);
            int[] vs = new int[k];
            int[] vs1 = new int[k - 1];
            int[] vs2 = new int[k + 1];
            int[] vs3 = new int[k];
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = random.Next(0, 20);
            }
            Console.WriteLine($"Вам дан рандомно заполненный массив размером в {k} значений");
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine($"{vs[i]}");
            }
            Console.WriteLine($"Выберете индекс значения (от 0 до {k - 1}), которое хотите удалить из массива");
            string index = Console.ReadLine();
            int s = Convert.ToInt32(index);
            Console.WriteLine("Итог:");
            for (int i = 0; i < vs.Length; i++)
            {
                while (s > i)
                {
                    vs1[i] = vs[i];
                    break;
                }
            }
            for (int i = s; i < vs1.Length; i++)
            {
                vs1[i] = vs[i + 1];
            }
            foreach (int b in vs1) Console.WriteLine($"{b}");
            Console.WriteLine();
            Console.WriteLine("Введите индекс элемента, куда вы хотите добавить значение\n(Добавление значения произойдёт в изначальный массив)");
            n = Console.ReadLine();
            s = Convert.ToInt32(n);
            for (int i = 0; i < vs.Length; i++)
            {
                while (s > i)
                {
                    vs2[i] = vs[i];
                    break;
                }
            }
            vs2[s] = random.Next(0, 20);
            for (int i = s + 1; i < vs2.Length; i++)
            {
                vs2[i] = vs[i - 1];
            }
            foreach (int b in vs2) Console.WriteLine($"{b}");
            Console.WriteLine("Циклическое перемещение элементов массива влево");
            for (int i = 0; i < vs.Length; i++)
            {
                while (i< vs.Length - 1)
                {
                    vs3[i] = vs[i+1];
                    break;
                }
            }
            vs3[k-1] = vs[0];
            foreach (int b in vs3) Console.WriteLine($"{b}");
            Console.WriteLine("Циклическое перемещение элементов массива вправо");
            for (int i = vs.Length-1; i >= 0; i--)
            {
                while (i > 0)
                {
                    vs3[i] = vs[i - 1];
                    break;
                }
            }
            vs3[0] = vs[k-1];
            foreach (int b in vs3) Console.WriteLine($"{b}");
        }
    }
}
