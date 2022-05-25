using System;

namespace pz_2_2PopovaElizaveta
{
    class Program
    {
        static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int buf = arr[i];
                        arr[i] = arr[j];
                        arr[j] = buf;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            Sort(array);
            for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
        }
    }
}
