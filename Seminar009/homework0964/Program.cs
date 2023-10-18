// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int PrintNatural(int n)
{
    if (n == 0) return n;
    Console.Write($"{n}  ");
    return PrintNatural(n-1);
}

Console.Write("Введите целое положительно число N (больше 1): ");
int n = int.Parse(Console.ReadLine());

if (n <= 1) Console.WriteLine("Число должно быть больше 1.");
PrintNatural(n);