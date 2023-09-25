Console.Clear();

Console.WriteLine("Введите число 1: ");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int numberTwo = int.Parse(Console.ReadLine());

if (numberOne * numberOne == numberTwo || numberTwo * numberTwo == numberOne)
{
    System.Console.WriteLine("Да, квадратики");
}
else
{
    System.Console.WriteLine("Ваааще нет");
}