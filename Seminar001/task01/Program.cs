// Коментарий, для примера работы 
// весь текс ctrl+/ в нижнем ряду около шифта, выделяя весь текст

// using System.ComponentModel;

Console.Write("Input number: ");

string numberString = Console.ReadLine()!;

int numberInt = Convert.ToInt32(numberString);
int result = numberInt * numberInt;

Console.WriteLine(result);
