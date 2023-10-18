// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

int SumOfNatural(int m, int n)
{
    if (m == n) return n;

    int sum = m + SumOfNatural(m + 1, n);
    return sum;
}

// int SumOfNatural(int m, int n)
// {
//     int sum = 0;
//     for (int i = m; i < n + 1; i++) sum = sum + i;
//     return sum;
// }

Console.Write("Введите целое положительно число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите целое положительно число N: ");
int n = int.Parse(Console.ReadLine());
int result = 0;

if (n < 0 || m < 0 || m == n)
{
    Console.WriteLine("Числа должны быть >= 0 и не должны быть равны.");
}
else if (m > n)
{
    result = SumOfNatural(n, m);
    Console.WriteLine($"Сумма чисел от N до M: {result}");
}
else
{
    result = SumOfNatural(m, n);
    Console.WriteLine($"Сумма чисел от M до N: {result}");
}
