Console.Clear();

// int numberOne = new Random().Next(10,100);
// int numberTwo = new Random().Next(1,10);
int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());

Console.WriteLine($"Первое число: {numberOne}, второе число: {numberTwo}");

int final = numberOne % numberTwo;

if (final != 0) Console.WriteLine($"Остаток: {final}");