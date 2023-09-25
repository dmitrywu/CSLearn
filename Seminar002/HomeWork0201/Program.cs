Console.Clear();

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Введённое число: {number}");

if (number < 100 || number > 999)
{
    Console.WriteLine("Число должно быть в диапазоне от 100 до 999");

}
else 
{
    int res = (number/10)%10;
    Console.WriteLine($"Ok, вторая цифра: {res}");
}

