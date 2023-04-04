// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(min, max + 1);
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4} ");
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
        Console.WriteLine($"{i + 1} строка: {array[i]} ");
    Console.Write($"{array.Length} строка: {array[array.Length - 1]}");
}
void PrintPositionMatchingNumberArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == number) Console.Write($"{i + 1} ");
}
int[] SumNumberRowsMatrix(int[,] matrix)
{
    int[] sumNumberRowsMatrix = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumNumberRowsMatrix[i] = sum;
    }
    return sumNumberRowsMatrix;
}
int MinNumberArray(int[] array)
{
    int minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < minNumber)
            minNumber = array[i];
    return minNumber;
}
///////// Метод наход первую строку с минимальной суммой элементов
// int FindFirstIndexMinNumberArray(int[] array)
// {
//     int indexMinNumber = 0;
//     for (int i = 1; i < array.Length; i++)
//         if (array[i] < array[indexMinNumber]) indexMinNumber = i;
//     return indexMinNumber;
// }
bool Verification(int rows, int colums)
{
    return rows <= 0 || colums <= 0;
}

Console.WriteLine("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int column = Convert.ToInt32(Console.ReadLine());

if (Verification(row, column))
{
    Console.Write("Введены некорректные данные");
    return;
}
int[,] array2d = CreateMatrix(row, column, 1, 4);
Console.WriteLine("Сформировался следующий двумерный массив");
PrintMatrix(array2d);

int[] arrSumNumbersInRow = SumNumberRowsMatrix(array2d);
Console.WriteLine("Сумма элементов в строках");
PrintArray(arrSumNumbersInRow);
Console.WriteLine();
int minNumber = MinNumberArray(arrSumNumbersInRow);

Console.Write($"Номер(a) строк(и) с наименьшей суммой элементов: ");
PrintPositionMatchingNumberArray(arrSumNumbersInRow, minNumber);