Console.Clear();

Console.WriteLine("Введите номер четверти (1-4): ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1: 
        Console.Write("X>0, Y>0");
        break;
    case 2: 
        Console.Write("X<0, Y>0");
        break;
    case 3: 
        Console.Write("X<0, Y<0");
        break;
    case 4: 
        Console.Write("X>, Y<0");
        break;
    default:
        Console.Write("Некорректное значение");
        break;

}