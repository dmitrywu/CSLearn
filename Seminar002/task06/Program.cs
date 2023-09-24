int number = Random.Shared.Next(10, 100);
int firstDigit = number / 10;
int lastDigit = number % 10;

Console.Clear();

Console.WriteLine("Сгенерированное число: " + number);

if (firstDigit > lastDigit)
{
    System.Console.WriteLine("Первая цифра больше второй: " + firstDigit + " > " + lastDigit);
}
else if (firstDigit < lastDigit)
{
    System.Console.WriteLine("Вторая цифра больше первой: " + lastDigit + " > " + firstDigit);
}
