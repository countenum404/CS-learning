using System;

namespace std
{
    class fc
    {   
        static int[,] Input(int m, int n)
        {
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {   
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }
        static void Output(int[,] matrix, int m, int n)
        {
            Console.WriteLine("Generated Matrix:");
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                if (i > i - 1)
                {
                    Console.Write("\n");
                }
            }
        }
        static int[,] MatMul(int[,] first, int[,] second, int m1, int n1, int n2)
        {
            int[,] M = new int[m1, n2];
            int element = 0;
            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    for (int k = 0; k < n2; k++)
                    {
                        M[i, k] += first[i, j] * second[j, k];
                    }
                }
            }
            return M;
        }
      
        public static void Main(string[] args)
        {
            Console.Title = "MultyPly Matrix";
            Console.WriteLine("Enter matrix1 rows:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter matrix1 cols:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter matrix2 rows:");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter matrix2 cols:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 != m2)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Impossible to multiply matrices.");
                Console.WriteLine("--------------------------------");
            }
            else
            {
                //input numbers numbers
                Console.WriteLine("Type one by one row matrix elements: ");
                int[,] matrix1 = Input(m1, n1);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Anotherone matrix");
                Console.WriteLine("--------------------------------");
                int[,] matrix2 = Input(m2, n2);
                //Output numbers
                Output(matrix1, m1, n1);
                Output(matrix2, m2, n2);
                Console.ReadKey();
                int[,] M = MatMul(matrix1, matrix2, m1, n1, n2);
                Console.WriteLine("Your answer");
                Console.WriteLine("--------------------------------");
                Output(M, m1, n2);
            }
        }
    }
}
