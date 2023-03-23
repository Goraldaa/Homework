// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] CreateArray(int arrayLength, int min, int max)
{
    int[] newArray = new int[arrayLength];
    
    Random random = new Random();

    for(int i = 0; i < arrayLength; i++)
    {
        newArray[i] = random.Next(min, max + 1);
    }

    return newArray;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int CountDoubleDigit(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 9 && array[i]< 100) count++;
    }
    return count;
}

Console.WriteLine("Давайте создадим массив.");
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 0)
{
    Console.WriteLine($"Ошибка: введено неверное значение {arraySize}. Размер массива должен быть положительным числом.");
    return;
}
Console.Write("Введите минимально возможное число в массиве:");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число в массиве:");
int maxNum = Convert.ToInt32(Console.ReadLine());
if (minNum > maxNum)
{
    Console.WriteLine($"Ошибка: минимальное значение массива не может превышать максимальное, попробуйте снова");
    return;
}

int[] arr = CreateArray(arraySize, minNum, maxNum);
int countDoubleDigit = CountDoubleDigit(arr);

Console.Write("В массиве ");
PrintArray(arr);
Console.Write($" {countDoubleDigit} двузначных чисел");