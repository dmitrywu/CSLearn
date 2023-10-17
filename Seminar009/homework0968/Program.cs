// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9

// Наоборот, на вики сначала идёт N, потом M
// m = 2, n = 3 -> A(m,n) = 29 ---- (9)
// m = 3, n = 2 -> A(m,n) = 9 ----(29)

using System;

Console.Clear();

int AkkerMan(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkerMan(m - 1, 1);
    else return AkkerMan(m - 1, AkkerMan(m, n - 1));
}

Console.Write("Введите целое положительно число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите целое положительно число N: ");
int n = int.Parse(Console.ReadLine());

// тут должна быть обработка эксепшенов, но не в 3 часа ночи разбираться, как оно работает :)

int result = 0;

if (n < 0 || m < 0)
{
    Console.WriteLine("Числа M и N должны быть равны 0 или больше 0.");
}
else
{
    result = AkkerMan(m, n);
    Console.WriteLine($"Результат ({m},{n}): {result}");
}

