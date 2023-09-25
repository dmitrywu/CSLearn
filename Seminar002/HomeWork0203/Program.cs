Console.Clear();

Console.Write("Введите номер дня недели (1-7): ");
int number = int.Parse(Console.ReadLine());
//,,..Console.WriteLine($"Введённое число: {number}");

if (number <1 || number >7)
{
    Console.WriteLine("Не подходит, введите цифру от 1 до 7");
}
else 
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
