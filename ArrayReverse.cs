using System;

namespace MatrixOpsDLL
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(1, 10);
            int[] randomarray = new int[n];
            for(int i = 0; i < randomarray.Length; i++)
            {
                randomarray[i] = random.Next(100);
            }
            Output(randomarray);
            Console.WriteLine();
            int[] revarray = Reverse(randomarray);
            Output(revarray);
            
        }
        public static int[] Reverse(int[] arr)
        {
            int tmp;
            for (int i = 0, j = arr.Length; i < j; i++, j--)
            {
                // 1 10 9 8 7 32
                tmp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tmp;
            }
            return arr;
        }
        public static void Output(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
