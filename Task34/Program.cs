//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] CreateArray(int arrayLength, int min, int max)
{
    int[] newArray = new int[arrayLength];

    Random random = new Random();

    for (int i = 0; i < arrayLength; i++)
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
int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    return count;
}

Console.WriteLine("Давайте создадим массив.");
Console.Write("Введите размер массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(arrSize, 100, 1000);
int countNumber = CountEvenNumber(arr);
Console.Write("В массиве ");
PrintArray(arr);
Console.Write($" количество чётных чисел равно {countNumber} ");
