using System;


public delegate void Delegate();

namespace PZ_9_Sobitiya
{
    public class Temperature
    {
        public int num;
        public Temperature(int x)
        {
            num = x;
        }

        public void Gradus()
        {
            Vivod a = new Vivod();
            for (int i = -30; i < 41; i++)
            {
                a.ActiveateEvent(i);

                if (i == 35) break;
            }
        }
    }
    public class Vivod
    {
        public event Delegate num_get;
        public void ActiveateEvent(int now)
        {

            if (now == -25)
            {
                num_get = MinDP;
            }
            else if (now == 0)
            {
                num_get = Nol;
            }
            else if (now == 25)
            {
                num_get = DP;
            }
            else if (now == 35)
            {
                num_get = Plus;
            }
            else num_get = null;
            if (num_get != null) num_get();
        }
        void MinDP()
        {
            Console.WriteLine("-25, Можно покататься на лыжах");
        }
        void DP()
        {
            Console.WriteLine("+25, Можно искупаться в речке");
        }
        void Nol()
        {
            Console.WriteLine("0, Ещё холодно, надень шапку!");
        }
        void Plus()
        {
            Console.WriteLine("+35, Надень панамку, а то хватит удар!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Temperature b = new Temperature(1);
            b.Gradus();
        }
    }
}
