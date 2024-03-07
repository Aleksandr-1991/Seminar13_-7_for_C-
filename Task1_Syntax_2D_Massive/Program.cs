// №46. Задайте 2-мерный массив размером m x n, заполненный случ целыми числами.
int Promt (string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int []   array   = new int [8];
int [,]  array2d = new int [8, 8];
int [,,] array3d = new int [8, 8, 8];  // - одно-, двух- и трёхмерный массив.

int [,] GetArray2d()
{
    int m = Promt("Введите значение m: ");
    int n = Promt("Введите значение n: ");
    int [,]  array2d = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2d [i, j] = new Random().Next(1, 10);
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
}

array2d = GetArray2d();
PrintMatrix(array2d);