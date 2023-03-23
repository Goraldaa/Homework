//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int SumElementsOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum += array[i];
    return sum;
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
int sum = SumElementsOddPositions(arr);
PrintArray(arr);
Console.WriteLine($" cумма элеменотов массива с нечётными индексами равна {sum}");
