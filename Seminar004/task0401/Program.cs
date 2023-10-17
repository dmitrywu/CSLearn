Console.Clear();

int ReadNumber(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    return value;
    //  return int.Parse(Console.ReadLine()!);
}

int SumFrom1ToA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
        // sum += i;
    }
    return sum;
}

int number = ReadNumber("Введите число А: ");
int result = SumFrom1ToA(number);

Console.WriteLine($"Сумма чисел от 1 до {number}: {result}");