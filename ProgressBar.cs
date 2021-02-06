using System;

namespace Project
{
    class ProgressBar
    {
        
        static void ProgressBar(int size = 10, int sec = 1)
        {
            int seconds = sec * 1000;
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
                System.Threading.Thread.Sleep(seconds);
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
