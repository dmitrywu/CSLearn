Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    Console.WriteLine("Yes, result is: " + number % 10);
}
else
{
    Console.WriteLine("wrong number");
}