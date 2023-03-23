// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
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
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
}
int[] ProductNumbers(int[] array)
{
    int count = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
    int[] newArray = new int[count];
    for (int i = 0; i < count; i++)
    {
        if (i == array.Length - 1 - i) newArray[i] = array[i];
        else newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return newArray;
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
int[] newArr = ProductNumbers(arr);

Console.Write("[");
PrintArray(arr);
Console.Write("] -> ");
PrintArray(newArr);
