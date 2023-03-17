// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountDigit(int number)
{
    int count = 0;
    while(number != 0)
    {
        number /= 10;
        count ++;
    }
    return count;
}

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

int result = CountDigit(num);

Console.WriteLine($"количество цифр в числе {num} равно {result}");

