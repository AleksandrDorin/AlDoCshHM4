// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
double[,] FillArray(int x, int y)
{
    double[,] array = new double[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 4);
        }
    }
    return array;
}
void PrintArray(double[,] tabl)
{
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        Console.Write("( ");
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            Console.Write($"{tabl[i, j]} ");
        }
        Console.Write(") ");
    }
}
void scaling(double[,] array, double k)
{
    double[,] array2 = new double[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("( ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[i, j] = array[i, j] * k;
            Console.Write($"{array2[i, j]} ");
        }
        Console.Write(") ");
    }

}
double[,] array = FillArray(4, 2);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите коэффициент масштабирования k: 2 / 4 / 0,5 ");
double kof = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
scaling(array, kof);