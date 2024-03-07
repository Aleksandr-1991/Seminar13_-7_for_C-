// №47. Задайте 2d-массив размером m x n, заполненный случайными вещественнными числами.
// /*
int Promt (string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
void FillArray(double[,] matrix)
{
    int minLimitRandom = Promt("Введите минимум диапазона случайных чисел, для заполнения каждого элемента массива: ");
    int maxLimitRandom = Promt("Введите максимум диапазона случайных чисел, для заполнения каждого элемента массива: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = minLimitRandom + new Random().NextDouble() * (maxLimitRandom - minLimitRandom); // - Запомнить!
        }
    }
}
void PrintArray(double[,] matrix)
{
    Console.WriteLine("[ ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2}\t"); // - Запомнить!
        }
        Console.WriteLine();
    }
    Console.WriteLine("]");
}

int m = Promt("Введите число m, отвечающее за количество строк: ");
int n = Promt("Введите число n, отвечающее за количество столбцов: ");
double[,] array2d = new double[m, n];
FillArray(array2d);
PrintArray(array2d);                //*/

// 
/*
using System;
public class Answer {
  public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) 
{
  double[,] array2d = new double[m, n];
  for (int i = 0; i < array2d.GetLength(0); i++)
  {
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
      array2d[i, j] = minLimitRandom + new Random().NextDouble() * (maxLimitRandom - minLimitRandom);
    }
  }
  return array2d;
}

public static void PrintArray(double[, ] matrix) 
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]:f2}\t");
    }
    Console.WriteLine();
  }
}

  // Не удаляйте и не меняйте метод Main! 
  public static void Main(string[] args) {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

        // Выберем случайные индексы трех элементов матрицы array
        int row1 = new Random().Next(0, m);
        int col1 = new Random().Next(0, n);
        int row2 = new Random().Next(0, m);
        int col2 = new Random().Next(0, n);
        int row3 = new Random().Next(0, m);
        int col3 = new Random().Next(0, n);

        // Проверяем, являются ли выбранные элементы дробными числами
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

        // Если два из трех элементов не являются дробными числами, то бросаем исключение
        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }
    } else {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;
      
      double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
}         //*/