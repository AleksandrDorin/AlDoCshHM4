// Написать программу копирования массива

int[] UserSizeArray()
{
    Console.Write("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine() ?? "0");
    int[] array = new int[size];
    return array;
}

void FillRandomArray(int[] array)
{
    Console.Write("Введите минимальное значение массива: ");
    int min = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите максимальное значение массива: ");
    int max = int.Parse(Console.ReadLine() ?? "0");

    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
}
void PrintArray(int[] arrayCol)
{
    Console.WriteLine("Массив :");
    foreach (var element in arrayCol)
        Console.Write($"{element} ");
    Console.WriteLine();
}
void copyarray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
        Console.Write($"{copyArray[i]} ");
    }
}

int[] array = UserSizeArray();
FillRandomArray(array);
PrintArray(array);
Console.WriteLine("");
copyarray(array);