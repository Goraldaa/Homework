// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
bool Verification(int[,] matrixFirst, int[,] matrixSecond)
{
    return (matrixFirst.GetLength(1) != matrixSecond.GetLength(0));
}
int[,] MatrixMultiplication(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] matrixMultiplication = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < matrixMultiplication.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMultiplication.GetLength(1); j++)
        {
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                sum += matrixFirst[i, k] * matrixSecond[k, j];
            }
            matrixMultiplication[i, j] = sum;
            sum = 0;
        }
    }
    return matrixMultiplication;
}
int[,] array2dFirst = CreateMatrix(4, 4, 1, 2);
int[,] array2dSecond = CreateMatrix(4, 3, 1, 3);
Console.WriteLine("Первая матрица");
PrintMatrix(array2dFirst);
Console.WriteLine("Вторая матрица");
PrintMatrix(array2dSecond);
Console.WriteLine();
if (Verification(array2dFirst, array2dSecond))
{
    Console.WriteLine("Матрицу P можно умножить на матрицу K только в том случае, если число столбцов матрицы P равняется числу строк матрицы K. В указанных матрицах это условие не выполняется.");
    return;
}
Console.WriteLine("Произведение матриц:");
int[,] result = MatrixMultiplication(array2dFirst, array2dSecond);
PrintMatrix(result);