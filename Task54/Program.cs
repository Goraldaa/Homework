// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }

        Console.Write("|");
        Console.WriteLine();

    }
}
void SortMatrixInRows(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int indexMaxValue = i;
            int temp = matrix[k, indexMaxValue];
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                if (matrix[k, j] > matrix[k, indexMaxValue]) indexMaxValue = j;
            }
            matrix[k, i] = matrix[k, indexMaxValue];
            matrix[k, indexMaxValue] = temp;
            indexMaxValue = i + 1;
        }
    }
}

int[,] array2d = CreateMatrix(6, 6, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
SortMatrixInRows(array2d);
PrintMatrix(array2d);
// int[] testArr = new int[] { 1, 5, 6, 7, 8, 2 };
// SortArray(testArr);
// PrintArray(testArr);

