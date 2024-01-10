   private static int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
    {
        var resultMatrix = new int[DIM, DIM];

        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
                Console.Write(resultMatrix[i, j] + ", ");
            }
            Console.WriteLine();
        }

        return resultMatrix;
    }


static void Main(string[] args)
        {
            int[,] matrix1 = new int[,] { { 1, 2, 3 }, { 3, 2, 1 }, { 1, 1, 1 } };
            Console.WriteLine("\nПервая матрица:\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", matrix1[i, j]);
                }
                Console.WriteLine(" ");
            }
 
            int[,] matrix2 = new int[,] { { 3, 2, 1 }, { 1, 2, 3 }, { 2, 2, 2 } };
            Console.WriteLine("\nВторая матрица:\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", matrix2[i, j]);
                }
                Console.WriteLine(" ");
            }
 
            int[,] matrix3 = Multiplication(matrix1, matrix2);
            Console.WriteLine("\nПроизведение матриц:\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", matrix3[i, j]);
                }
                Console.WriteLine(" ");
            }
 
            Console.ReadKey();
        }
        static int[,] Multiplication(int[,] a, int[,] b)
        {
            int[,] r = new int[a.Length, b.Length];
            for (int i = 0; i < b.GetLength(1); i++)
            {
                for (int j = 0; j < b.GetLength(0); j++)
                {
                    r[i, j] = 0;
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }