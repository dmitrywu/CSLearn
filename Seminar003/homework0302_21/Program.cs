﻿Console.Clear();

//Math.Sqrt() – математическая функция которая извлекает квадратный корень. В аргументных скобках указывается значение числа, из которого нужно извлечь квадратный корень.
//Math.Sqrt(x)
//Math.Pow() – возведения числа в степень. В аргументных скобках через запятую указываются два аргумента (1-ый аргумент - число, которое возводим в степень, 2-ой – степень, в которую возводим число).
//Math.Pow(x, y)
//result = Math.Sqrt((x2-x1),2)

int xFin = Math.Pow((x2-x1),2);
int yFin = Math.Pow((y2-y1),2);
int zFin = Math.Pow((z2-z1),2);
int result = Math.Sqrt(xFin+yFin+zFin);

