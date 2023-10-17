Console.Clear();

int[] array = new int[8];

for(int i=0;i<array.Length;i++)
{
    array[i]=Random.Shared.Next(0,2);
    Console.WriteLine($"{i}: {array[i]} ");
}
