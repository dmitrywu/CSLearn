// Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("-----------------------");

int number1=number%1;
Console.WriteLine($"%1: {number1}");
int number10=number%10;
Console.WriteLine($"%10: {number10}");
int number100=number%100;
Console.WriteLine($"%100: {number100}");
int number1000=number%1000;
Console.WriteLine($"%1000: {number1000}");
int number10000=number%10000;
Console.WriteLine($"%10000: {number10000}");
int number100000=number%100000;
Console.WriteLine($"%100000: {number100000}");

Console.WriteLine("-----------------------");

int dnumber1=number/1;
Console.WriteLine($"/1: {dnumber1}");
int dnumber10=number/10;
Console.WriteLine($"/10: {dnumber10}");
int dnumber100=number/100;
Console.WriteLine($"/100: {dnumber100}");
int dnumber1000=number/1000;
Console.WriteLine($"/1000: {dnumber1000}");
int dnumber10000=number/10000;
Console.WriteLine($"/10000: {dnumber10000}");
int dnumber100000=number/100000;
Console.WriteLine($"/100000: {dnumber100000}");


