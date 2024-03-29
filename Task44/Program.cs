﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int[] Fibonachy(int number)
{
    int[] array = new int[number];
    if (number > 1)
    {
        array[1] = 1;
        for (int i = 2; i < array.Length; i++)
            array[i] = array[i - 1] + array[i - 2];
    }
    return array;
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


Console.Clear();
Console.WriteLine("Введите количество чисел Фибоначи");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = Fibonachy(num);
PrintArray(arr);