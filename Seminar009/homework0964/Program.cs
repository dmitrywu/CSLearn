// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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
