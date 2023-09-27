Console.Clear();

Console.WriteLine("Введите X: ");
int numberX = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int numberY = int.Parse(Console.ReadLine());

if (numberX > 0 && numberY > 0)
{
    Console.WriteLine("Точка находится в 1-й координатной четверти");
}
else if (numberX <0 && numberY>0)
{
    Console.WriteLine("Точка находится в 2-й координатной четверти");
}
else if (numberX <0 && numberY<0)
{
    Console.WriteLine("Точка находится в 3-й координатной четверти");
}
else if (numberX >0 && numberY < 0)
{
    Console.WriteLine("Точка находится в 4-й координатной четверти");
}
else
{
    Console.WriteLine("Невозможно определить номер четверти точки");
}
