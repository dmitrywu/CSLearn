// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

int check = number % 2;

if (check == 0)
{
    Console.Write("Число " + number + " чётное");
}
else
{
    Console.Write("Число " + number + " НЕчётное");
}

