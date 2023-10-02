//tаблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

Console.Clear();

Console.WriteLine("Введите число (больше или равно 1): ");
int number = int.Parse(Console.ReadLine());
int idx = 1;
int NumPow;

if (number<1)
{
    Console.WriteLine("Число должно быть больше или равно 1");
}
else if (number == 1)
{
    Console.WriteLine("1. и всё.");
}
else 
{
    for (idx = 1; idx<=number; idx++)
    {
        NumPow = idx*idx;
        Console.Write($"{idx}^2 = {NumPow}   ");
    }
}