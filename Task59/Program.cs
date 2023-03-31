
// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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
int[] CoordinatesMinimumValue(int[,] matrix)
{
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minRow, minColumn])
            {
                minRow = i;
                minColumn = j;
            }
        }
    }
    return new int[] { minRow, minColumn };
}
int[,] MatrixWithoutRowColumnMinValue(int[,] matrix, int[] coords)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0, newRow = 0; i < matrix.GetLength(0); i++)
    {
        if (i == coords[0]) continue;
        for (int j = 0, newColumn = 0; j < matrix.GetLength(1); j++)
        {
            if (j == coords[1]) continue;
            newMatrix[newRow, newColumn] = matrix[i, j];
            newColumn++;
        }
        newRow++;
    }
    return newMatrix;
}

int[,] array2d = CreateMatrix(5, 7, -10, 10);
PrintMatrix(array2d);
int[] coordinates = CoordinatesMinimumValue(array2d);
int[,] newArray2d = MatrixWithoutRowColumnMinValue(array2d, coordinates);
Console.WriteLine();
PrintMatrix(newArray2d);