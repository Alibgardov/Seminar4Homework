Console.Clear();
int items = 8;
int[] array = new int[items];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)

{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}