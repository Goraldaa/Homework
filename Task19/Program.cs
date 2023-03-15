// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// Сделала универсальную программу

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
int size_num = num[0] == '-'? num.Length - 1 : num.Length;
int number_int = Convert.ToInt32(num);
if(number_int < 0) number_int *= -1;


Console.WriteLine(Poli(number_int, size_num) ? "да" : "нет");

