// 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int FindThirdDigit(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    int result = num % 10;
    return result;
}


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;
if (number > 99) Console.WriteLine("Третья цифра - " + FindThirdDigit(number));
else Console.WriteLine("Третьей цифры в числе нет");

