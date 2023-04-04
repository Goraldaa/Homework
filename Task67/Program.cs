// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int SumDigits(int n)
{
    if (n == 0) return 0;
    else return n % 10 + SumDigits(n / 10);
}
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(number));
