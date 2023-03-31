// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixmatrix(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];

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
            Console.Write($"{matrix[i, j], 4} ");
        }

        Console.Write("|");
        Console.WriteLine();

    }
}

int SumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0);
    if (matrix.GetLength(0)>matrix.GetLength(1)) size = matrix.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i,i];
    }
    return sum;
}



int[,] array2d = CreateMatrixmatrix(6, 4, 1, 10);
PrintMatrix(array2d);
int result = SumMainDiagonal(array2d);
Console.WriteLine();
Console.Write($"Сумма элементов главной диагонали: {result}");