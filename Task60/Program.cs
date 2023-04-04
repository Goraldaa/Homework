// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int[,,] CreateMatrix3D(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int number = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = number;
                number +=1;
            }
        }
    }
    return matrix;
}
void PrintMatrix3D(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
bool Verification(int[,,] matrix3d)
{
    return matrix3d.Length>90;
}

int[,,] array3d = CreateMatrix3D(4,2,2);
if(Verification(array3d))
{
    Console.WriteLine("Массив слишком большой. Невозможно заполнить неповторяющимися двузначными цифрами.");
    return;
}
PrintMatrix3D(array3d);
