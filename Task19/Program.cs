// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

bool Poli(int number, int size)
{
    int i = 1;
    while (i < size)
    {
        int pow = Convert.ToInt32(Math.Pow(10, size - i));
        int firstDigit = number /  pow ;
        int lastDigit = number % 10;
        if (firstDigit != lastDigit) return false;
        else number = (number - firstDigit * pow) / 10;
        i += 2;
    }
    return true;
}


Console.WriteLine("Введите число");
string num = Console.ReadLine();
int size = num[0] == '-'? num.Length - 1 : num.Length;
int number = Convert.ToInt32(num);
if(number < 0) number *= -1;


Console.WriteLine(Poli(number, size) ? "да" : "нет");

