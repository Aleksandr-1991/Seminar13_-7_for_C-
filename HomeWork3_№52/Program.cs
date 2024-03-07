// №52 Дом. Задайте 2d-массив целых чисел. Най среднее арифм элементов в каждом столбце.
int Promt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] array2d = new int[n, m];
    int temp = 1;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = temp;
            temp += k;
        }
    }
    return array2d;
}
void PrintArray2d(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2}\t"); // - Запомнить!
        }
        Console.WriteLine();
    }
}

double[] Average(int [,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0; // обязательно вынести за цикл?
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        average[j] = sum / matrix.GetLength(0);
    }
    return average;
}

int n = Promt("Введите число n, отвечающее за количество строк: ");
int m = Promt("Введите число m, отвечающее за количество столбцов: ");
int k = Promt("Введите число k, отвечающее за шаг увеличивающегося массива: ");
int[,] matrix = CreateIncreasingMatrix(n, m, k);
PrintArray2d(matrix);
double[] average = Average(matrix);
Console.Write(string.Join("\t", average));