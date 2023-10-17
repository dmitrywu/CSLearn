Console.Clear();

int[] GetRndArray(int Length, int leftBorder, int rightBorder)
{
    int[] array = new int[Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);

    }
    return array;
}

int sumPositiveElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int sumNegativeElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

const int Length = 12;
const int LeftBorder = -9;
const int RightBorder = 9;

int[] myArray = GetRndArray(Length, LeftBorder, RightBorder);
string myArrayString = string.Join(", ", myArray);
Console.WriteLine(myArrayString);

int sumPositive = sumPositiveElementsArray(myArray);
int sumNegative = sumNegativeElementsArray(myArray);

Console.WriteLine($"Сумма положительных элементов массива: {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegative}");

