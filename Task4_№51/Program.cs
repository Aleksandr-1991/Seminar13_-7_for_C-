// №51. Задайте 2d-массив. Най эл.., у к-ых оба индекса Нечётные, и замените эти эл.. на их квадраты.
int Promt (string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int [,] GetArray2d()
{
    int m = Promt("Введите значение m: ");
    int n = Promt("Введите значение n: ");
    int k = 0;
    int [,]  array2d = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {  
            // array2d [i, j] = new Random().Next(1, 10);
            array2d [i, j] = k;
            k++;
        }
    }
    return array2d;
}
int SumElementsOfMainDiagonal(int [,] array2d)
{
    int sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array2d [i, j];
                // Console.WriteLine(sum);
            }
        }
    }
    return sum;
}
void PrintMatrix (int [,]  matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
        Console.WriteLine();
}

int [,] array2d = GetArray2d();
PrintMatrix(array2d);
Console.Write(SumElementsOfMainDiagonal(array2d));