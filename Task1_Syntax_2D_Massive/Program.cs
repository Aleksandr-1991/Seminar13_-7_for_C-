// №46. Задайте 2-мерный массив размером m x n, заполненный случ целыми числами.
// m = 3; n = 4.
// 1  4  8 19
// 5 -2 33 -2
// 77 3  8  3
int Promt (string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
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
void PrintArray2d (int [,]  array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write (array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

array2d = GetArray2d();
PrintArray2d(array2d);