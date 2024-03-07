// №49. Задайте 2d-массив. Най эл.., у к-ых оба индекса Нечётные, и замените эти эл.. на их квадраты.
int Promt (string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int [,] GetArray2d()
{
    int n = Promt("Введите значение m: ");
    int m = Promt("Введите значение n: ");
    int [,]  array2d = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {  
            array2d [i, j] = new Random().Next(1, 10);
        }
    }
    return array2d;
}
int [,] ResultArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                array2d [i, j] = array2d [i, j] * array2d [i, j];
            }
        }
    }
    return array2d;
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
PrintArray2d(array2d);
PrintArray2d(ResultArray(array2d));