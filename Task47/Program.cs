// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateMatrixDouble(int rows, int colums, double min, double max)
{
    double[,] matrix = new double[rows, colums];

    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double temp = random.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(temp, 1);
        }
    }

    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],6} ");
        Console.WriteLine();
    }
}


double[,] array2d = CreateMatrixDouble(3, 4, -100, 100);
PrintMatrixDouble(array2d);