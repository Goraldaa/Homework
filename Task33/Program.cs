// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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

bool FindNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

Console.Clear();

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

Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(arraySize, minNum, maxNum);
bool result = FindNumber(arr, number);

Console.Write("В массиве ");
PrintArray(arr);
Console.WriteLine(result ? $" число {number} присутствует" : $" число {number} не присутствует");
