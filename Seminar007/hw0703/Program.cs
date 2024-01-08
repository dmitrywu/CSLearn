


using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine("");
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. 
        // Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) 
        // и возвращает матрицу, удовлетворяющую этим условиям.
        // Введите свое решение ниже
        int[,] matrix = new int[n, m];
        int value = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value;
                value += k;
            }
        }
        return matrix;
    }

    static void PrintListAvr(double[] list)
    {
        // Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате
        // The averages in columns are:
        // x.x0 x.x0 x.x0 ..., где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой 
        //(в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.
        // Введите свое решение ниже


    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. 
        // Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.
        // Введите свое решение ниже
        double[] avgvalue = new double[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                
            }
            
        }

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}