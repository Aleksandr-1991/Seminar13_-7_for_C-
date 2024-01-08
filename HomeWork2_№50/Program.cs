// №50. Дом. Прога приним на вход позицию элемента в 2d-массиве и возвращ значение этого эл. или указание что такого эл. нет.
// using Internal;
// using System;
// public class Answer
// {
    static void PrintArray (int [,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    static int[,] CreateIncreasingMatrix(int n, int m, int k)
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
    static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int[] result = { 0, 1 };
        if (rowPosition < matrix.GetLength(0) && rowPosition >= 0 && columnPosition < matrix.GetLength(1) && columnPosition >= 0)
        {
           result[0] = matrix[rowPosition, columnPosition];
           result[1] = 0;
        }
        return result;
    }
    static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
        if(results[1] == 1) Console.WriteLine("There is no such index");
        if(results[1] == 0) Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }
// }
// Не удаляйте и не меняйте метод Main! 
// void Main(string[] args)
// {
//     int n, m, k, x, y;
//     if (args.Length >= 5)
//     {
//         n = int.Parse(args[0]);
//         m = int.Parse(args[1]);
//         k = int.Parse(args[2]);
//         x = int.Parse(args[3]);
//         y = int.Parse(args[4]);
//     }
//     else
//     {
        // Здесь вы можете поменять значения для отправки кода на Выполнение
       int n = 3;
       int m = 4;
       int k = 2;
       int x = 1;
       int y = 2;
    // }
    // Не удаляйте строки ниже
    int[,] result = CreateIncreasingMatrix(n, m, k);
    PrintArray(result);
    PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
// }