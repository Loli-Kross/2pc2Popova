using System;
using System.Text.RegularExpressions;

namespace pz_19PopovaElizaveta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine();
            string text = Console.ReadLine();
            string newtext = Regex.Replace(text, @"fax:", "");
            string newtext1 = Regex.Replace(newtext, @"tel:", "");
            string newtext2 = Regex.Replace(newtext1, @"fax", "");
            string newtext3 = Regex.Replace(newtext2, @"tel", "");
            Console.WriteLine(newtext3);
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine("1.");
            text = Console.ReadLine();
            Regex r1 = new Regex(@"\d\d(\.)\d\d(\.)\d\d\d\d");
            Regex r = new Regex(@"\d\d(\.)\d\d(\.)\d\d");
            Match tel = r.Match(text);
            Match tel1 = r1.Match(text);
            while (tel.Success)
            {
                Console.WriteLine(tel);
                tel = tel.NextMatch();
            }
            while (tel1.Success)
            {
                Console.WriteLine(tel1);
                tel1 = tel1.NextMatch();
            }
            Console.WriteLine("2.");
            text = Console.ReadLine();
            Regex r3 = new Regex(@"\d\d(\:)\d\d");
            Match tel3 = r3.Match(text);
            while (tel3.Success)
            {
                Console.WriteLine(tel3);
                tel3 = tel3.NextMatch();
            }
            r3 = new Regex(@"\d\d(\.)\d\d");
            tel3 = r3.Match(text);
            while (tel3.Success)
            {
                Console.WriteLine(tel3);
                tel3 = tel3.NextMatch();
            }
            //Console.WriteLine("3.");
            //text = Console.ReadLine();
            //Random random = new Random();
            //Regex r2 = new Regex(@"\d[random]");
            //Match tel2 = r2.Match(text);
            //while (tel2.Success)
            //{
            //    Console.WriteLine(tel2);
            //    tel2 = tel2.NextMatch();
            //}
            //Console.WriteLine("4.");
            //text = Console.ReadLine();
            //Regex r4 = new Regex(@"\d[-10000.0000-10000.0000]");
            //Match tel4 = r4.Match(text);
            //while (tel4.Success)
            //{
            //    Console.WriteLine(tel4);
            //    tel4 = tel4.NextMatch();
            //}

        }
    }
}
