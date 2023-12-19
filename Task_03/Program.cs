
int[] array = { 15, 24, 13, 47, 51 };

Console.WriteLine("Элементы массива, начиная с конца:");
PrintArrayReverse(array, array.Length - 1);

static void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write($"{array[index]} ");
        PrintArrayReverse(array, index - 1);
    }
}