// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




int CountSpiral(int[,] matrix)
{
    int countHor = matrix.GetLength(1) % 2 == 0 ? matrix.GetLength(1) : matrix.GetLength(1) / 2 + 1;
    int countVert = matrix.GetLength(0) % 2 == 0 ? matrix.GetLength(0) : matrix.GetLength(0) / 2 + 1;
    int count = matrix.GetLength(0) > matrix.GetLength(1) ? countHor : countVert;
    return count;
}
void SpiralFillingMatrix(int[,] matrix, int row, int col, int numberFirst, int count)
{
    if (matrix[row, col] == 0)
    {
        for (int i = 0; i < count; i++)
        {
            matrix[row, col] = numberFirst;
            if (row == i && col < matrix.GetLength(1) - 1) SpiralFillingMatrix(matrix, row, col + 1, numberFirst + 1, count); // переход вправо
            if (col == matrix.GetLength(1) - 1 - i && row < matrix.GetLength(0) - 1) SpiralFillingMatrix(matrix, row + 1, col, numberFirst + 1, count); // переход ниже
            if (row == matrix.GetLength(0) - 1 - i && col > 0) SpiralFillingMatrix(matrix, row, col - 1, numberFirst + 1, count); // переход  влево
            if (col == i && row > 0) SpiralFillingMatrix(matrix, row - 1, col, numberFirst + 1, count); // переход выше
        }
    }
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4} ");
        Console.WriteLine();
    }
}

int[,] array2d = new int[10, 10];
//SpiralFillingMatrix(array2d, 1);
int countSpiral = CountSpiral(array2d);
SpiralFillingMatrix(array2d, 0, 0, 1, countSpiral);
PrintMatrix(array2d);
