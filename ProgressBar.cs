using System;

namespace Project
{
    class ProgressBar
    {
        
        static void ProgressBar(int size = 10, int mlsec = 500)
        {
            string bar ="[";
            for (int i = 1; i < size; i++)
            {
                bar += ".";
            }
            bar += "]";
            
            for(int i = 1; i < size; i++)
            {
                bar = bar.Remove(i, 1);
                bar = bar.Insert(i, "|");
                System.Threading.Thread.Sleep(mlsec);
                Console.Write("\r" + bar);
            }
        }

        public static void Main(string[] args)
        {
            ProgressBar(20);
            Console.ReadKey();
        }
    }
}
