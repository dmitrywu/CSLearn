// Напишите программу для работы с матрицей целых чисел.
// Реализуйте класс Answer, который содержит следующие статические методы:

// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix. 
// Метод принимает двумерный массив целых чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. Метод принимает двумерный массив 
// целых чисел matrix и возвращает массив из двух элементов: номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.

using System;

public class Answer
{
    public static int SumOfRow(int[,] matrix, int row)
    {
        // Введите свое решение ниже
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[row, j];
        }
        return sumRow;
    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
        // Введите свое решение ниже
        //int xxx = 0;
        int[] outmatrix = new int[] { 0, 0 };
        outmatrix[1]=SumOfRow(matrix,0);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            //xxx = SumOfRow(matrix, i);

            //Console.WriteLine($"{xxx}");
            //Console.WriteLine($"{SumOfRow(matrix, i)}");
            //Console.WriteLine($"{outmatrix[0]}\t{outmatrix[1]}");
            
            // maxxx[i] = SumOfRow(matrix, i);

            if (outmatrix[1] > SumOfRow(matrix, i))
            {
                outmatrix[1] = SumOfRow(matrix, i);
                outmatrix[0] = i;
            }






        }

        return outmatrix;
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                // {5, 2, 9},
                // {8, 1, 4},
                // {6, 7, 3}
                {9,1,7},
                {1,2,23},
                {4,5,6}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);

        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
    }
}