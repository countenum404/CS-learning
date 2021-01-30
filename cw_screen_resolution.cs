using System;

namespace str
{
    class str
    {
        static string Height(int width, string ratio)
        {
            string[] r = ratio.Split(":");
            int result = width * Convert.ToInt32(r[1]) / Convert.ToInt32(r[0]);
            return Convert.ToString(width) + "x" + Convert.ToString(result);
        }
        public static void Main(string[] args)
        {
            string output = Height(1024, "4:3");
            Console.WriteLine(output);
        }
    }
}
