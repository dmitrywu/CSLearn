Console.Clear();

Console.Write("Введите число (100 или больше): ");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет. Число меньше 100");
}
else
{
    while (number > 999)
    {
        number /= 10;
    }
    
    Console.Write($"Третья цифра: {number%10}");
}