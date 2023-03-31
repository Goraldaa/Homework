// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.




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

void MatrixSquareEvenPositions(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+= 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] *= matrix[i,j];
        }
    }
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

int[,] array2d = CreateMatrixmatrix(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
MatrixSquareEvenPositions(array2d);
PrintMatrix(array2d);