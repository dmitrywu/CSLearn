Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int arg1 = number/10000;
int arg2 = (number/1000)%10;
int arg4 = (number%100)/10;
int arg5 = number%10;
Console.WriteLine($"{arg1} {arg2} {arg4} {arg5}");

if ( number < 10000 || number > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else if (arg1==arg5 && arg2==arg4)
{
    Console.WriteLine("True (палиндром)");
}
else
{
    Console.WriteLine("False (НЕ палиндром)");
}