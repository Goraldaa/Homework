// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




// void SpiralFillingMatrix(int[,] matrix, int row, int col, int numberFirst)
// {
//     if (matrix[row, col] == 0)
//     {
//         matrix[row, col] = numberFirst;
//         numberFirst++;
//         if (row > 0 && col < matrix.GetLength(1) && matrix[row, col + 1] == 0 ) SpiralFillingMatrix(matrix, row - 1, col, numberFirst);
//         if (col < matrix.GetLength(1) - 1) SpiralFillingMatrix(matrix, row, col + 1, numberFirst); // переход вправо
//         if (row < matrix.GetLength(0) - 1) SpiralFillingMatrix(matrix, row + 1, col, numberFirst); // переход ниже
//         if (col > 0) SpiralFillingMatrix(matrix, row, col - 1, numberFirst); // переход  влево
//         if (row > 0) SpiralFillingMatrix(matrix, row - 1, col, numberFirst); // переход выше
           
//     }
// }
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4} ");
        Console.WriteLine();
    }
}

void SpiralFillingMatrix(int[,] matrix, int numberFirst)
{
    int numberSecond = numberFirst;
    int sizeHorizon = matrix.GetLength(1);
    int sizeVertical = matrix.GetLength(0);
    for (int i = 0; i < sizeHorizon; i++)
    {
        numberSecond = numberFirst + sizeHorizon + sizeVertical -2;
        matrix[0,i] = numberFirst;
        numberFirst++;
        matrix[sizeVertical-1, sizeHorizon -1-i] = numberSecond;
        numberSecond++;
    }
     for (int i = 1 ; i < sizeVertical -1; i++)
    {
        numberFirst = sizeHorizon + i;
        numberSecond = numberFirst + sizeHorizon + sizeVertical - 2;
        matrix[i, sizeVertical -1] = numberFirst;
        numberFirst++;
        matrix[sizeVertical - 1 -i, 0] = numberSecond;
        numberSecond ++;
    }
    
}




int[,] array2d = new int[4, 4];
SpiralFillingMatrix(array2d, 1);
PrintMatrix(array2d);
