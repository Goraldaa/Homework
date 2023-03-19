// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

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

int[] CreateArrayReadLine(int arrayLength)
{
    int[] newArray = new int[arrayLength];
    
    for (int i = 0; i < arrayLength; i++)
    {
       Console.Write($"Введите {i+1} число: ");
       newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
}


Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if(arraySize <= 0)
{
    Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
    return;
}

/////////////////////////////////////
//Создание и заполение массива псевдослучайными числами

Console.Write("Введите минимально возможное число в массиве:");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число в массиве:");
int maxNum = Convert.ToInt32(Console.ReadLine());


int[] arr = CreateArray(arraySize, minNum, maxNum);

//////////////////////////////////////
//Создание и заполение массивы с клавиатуры

//int[] arr = CreateArrayReadLine(arraySize);

PrintArray(arr);
Console.Write(" -> [");
PrintArray(arr);
Console.Write("]");

