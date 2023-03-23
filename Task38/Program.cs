// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int arrayLength, double min, double max)
{
    double[] newArray = new double[arrayLength];

    Random random = new Random();

    for (int i = 0; i < arrayLength; i++)
    {
        double num = random.NextDouble() * (max - min) + min;
        newArray[i] = Math.Round(num, 1, MidpointRounding.ToZero);
    }

    return newArray;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
double MaxNumber(double[] array)
{
    double maxNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i]) maxNumber = array[i];
    }
    return maxNumber;
}
double MinNumber(double[] array)
{
    double minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minNumber > array[i]) minNumber = array[i];
    }
    return minNumber;
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
int minNumArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число в массиве:");
int maxNumArr = Convert.ToInt32(Console.ReadLine());
if (minNumArr > maxNumArr)
{
    Console.WriteLine($"Ошибка: минимальное значение массива не может превышать максимальное, попробуйте снова");
    return;
}

double[] arr = CreateArray(arraySize, minNumArr, maxNumArr);
double maxNum = MaxNumber(arr);
double minNum = MinNumber(arr);
double result = maxNum - minNum;
double resultRound = Math.Round(result, 1, MidpointRounding.ToZero);
Console.Write("В массиве ");
PrintArray(arr);
Console.Write($" максимальное число равно {maxNum}, минимально число равно {minNum}, разница между ними составляет {resultRound}");

