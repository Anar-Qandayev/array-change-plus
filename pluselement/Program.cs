using System;

namespace pluselement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -6, 4, 8, -2 };

            int[] arr2 = Plus(arr);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]+" ");
            }
        }
        static int[] Plus(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min>arr[i])
                {
                    min = arr[i];
                }
                else if (max<arr[i])
                {
                    max = arr[i];
                }

            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                {
                    arr[i] = max;
                }
                else if (arr[i] == max)
                {
                    arr[i] = min;
                }

            }

            return arr;
        }
    }
}
