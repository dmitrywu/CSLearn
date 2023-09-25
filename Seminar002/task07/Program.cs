Console.Clear();

int number = new Random().Next(100,1000);

int firstDigit = number/ 100;
int lastDigit=number%10;

Console.WriteLine($"Gen: {number}, first: {firstDigit}, last: {lastDigit}");

int final = firstDigit*10+lastDigit;

Console.WriteLine($"Final: {final}");