using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 10, -20, 30, -40, 50, -60, 70 };

            int[] arr2 = ArrayPlus(arr);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }

        static int[] ArrayPlus(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    arr[i] = -arr[i];
            }
            return arr;
        }
    }
}
