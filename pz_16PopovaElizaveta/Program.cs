using System;

namespace pz_16PopovaElizaveta
{
    class Program
    {
        static void Quarter( int x, int y, out int result)
        {
            result = 0;
            if (x > 0)
            {
                if (y > 0)
                    result = 1;
                else if (y < 0)
                { 
                    result = 4;
                Console.WriteLine(result); }
            }
            else
            {
                if (y > 0)
                    result = 2;
                else if (y < 0) { 
                    result = 3;
                Console.WriteLine(result); }
            }
            
        } 
        static void Main(string[] args)
        {
            int r;
            int x, y;
            x = 4; y = -10;
            Quarter(x,  y, out r);
            x = -8; y = -9;
            Quarter( x,  y, out r);
            x = 7; y = 20;
            Quarter( x,  y, out r);
        }
    }
}
