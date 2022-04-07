
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
namespace pz_2_8PopovaElizaveta
{
    

    //1.Напишите программу, в которой объявляется делегат для методов с
    //двумя аргументами(символ и текст) и целочисленным результатом.В
    //главном классе необходимо описать два статических метода. Один
    //статический метод результатом возвращает количество вхождений символа
    //(первый аргумент) в текстовую строку(второй аргумент).Другой метод
    //результатом возвращает индекс первого вхождения символа(первый
    //аргумент) в текстовую строку(второй аргумент), или значение -1, если
    //символ в текстовой строке не встречается.В главном методе создать
    //экземпляр делегата и с помощью этого экземпляра вызвать каждый из
    //статических методов.

        delegate int Operation(char c, string s);

        class Program
        {
            static void Main(string[] args)
            {
                char c = 'o';
                string s = "hello world";
                Operation del = Entrance;
                int result = del(c, s);
                Console.WriteLine(result);

                del = Index;
                result = del(c, s);
                Console.WriteLine(result);
                Console.ReadKey();
            }

            // 1
            private static int Entrance(char c, string s)
            {
                int num = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (c == s[i])
                        num++;
                }
                if (num == 0)
                    return -1;
                return num;
            }
            // 2
            private static int Index(char c, string s)
            {
                return s.IndexOf(c);
            }
        }
}
