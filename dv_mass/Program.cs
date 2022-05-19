using System;

namespace dv_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите количество строк и столбцов массива:\nКоличество строк:");
            string n = Console.ReadLine();
            int k = Convert.ToInt32(n);
            Console.WriteLine("Количество столбцов:");
            n = Console.ReadLine();
            int y = Convert.ToInt32(n);
            int [,] vs = new int [k, y];
            int[] vs1 = new int[y];
            int[] vs2 = new int[y];
            int[,] vs3 = new int[k - 1, y];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    vs[i, j] = random.Next(0, 20);
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(vs[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Выберете 2 индекса строки, которые хотите поменять местами:\nИндекс первой строки");
            n = Console.ReadLine();
            int g = Convert.ToInt32(n);
            Console.WriteLine("Индекс второй строки:");
            n = Console.ReadLine();
            int h = Convert.ToInt32(n);
            for (int i = 0; i < y; i++)
            {
                vs1[i] = vs[g, i];
                vs2[i] = vs[h, i];
            }
            for (int i = 0; i < y; i++)
            {
                vs[g, i] = vs2[i];
                vs[h, i] = vs1[i];
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(vs[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Выберете строки значения (от 0 до {k - 1}), которую хотите удалить из массива");
            string index = Console.ReadLine();
            int s = Convert.ToInt32(index);
            Console.WriteLine("Итог:");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    while (s > i)
                    {
                        vs3[i, j] = vs[i, j];
                        break;
                    }
                }
            }
            for (int i = s; i < k - 1; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    vs3[i, j] = vs[i + 1, j];
                }
            }
            for (int i = 0; i < k - 1; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(vs3[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
