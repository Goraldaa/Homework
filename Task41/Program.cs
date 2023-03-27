// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArrayReadLine(int arrayLength)
{
    int[] newArray = new int[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    
}

Console.Write("Введите количество чисел:");
int arrSize = Convert.ToInt32(Console.ReadLine());
if (arrSize <= 0)
{
    Console.WriteLine($"Ошибка: введено неверное значение {arrSize}. Количество чисел должно быть равно или более 1.");
    return;
}
int[] arr = CreateArrayReadLine(arrSize);
int result = CountPositiveNumbers(arr);
Console.Write("Среди чисел ");
PrintArray(arr);
Console.Write($" количество положительных равно {result}");