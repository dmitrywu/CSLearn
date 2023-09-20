Console.WriteLine("Input 1s number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input 2s number");
int number2 = int.Parse(Console.ReadLine());

if (number1==number2*number2) 
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No :(");
}