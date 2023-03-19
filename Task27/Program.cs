// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int number)
{
    int sumDigits = 0;
    while (number != 0)
    {
        sumDigits += number % 10;
        number /= 10;
    }
    return sumDigits;
}

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int numAbs = Math.Abs(num);

int result = SumDigits(numAbs);
Console.WriteLine($"Сумма цифр в числе {num} равна {result}");


