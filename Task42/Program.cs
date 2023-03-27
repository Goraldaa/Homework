// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ConvertDecimalBinaryString(int numDecimal)
{
    string binary = "";
    if (numDecimal == 0) binary = "0";
    while (numDecimal != 0)
    {
        binary = Convert.ToString(numDecimal % 2) + binary;
        numDecimal /= 2;
    }
    return binary;
}
int ConvertDecimalBinaryInt(int numDecimal)
{
    int binary = 0;
    int count = 1;
    while (numDecimal != 0)
    {
        binary = numDecimal % 2 * count + binary;
        numDecimal /= 2;
        count *= 10;
    }
    return binary;
}

Console.Clear();
Console.WriteLine("Введите десятичное число");
int number = Convert.ToInt32(Console.ReadLine());
string result = ConvertDecimalBinaryString(number);
Console.WriteLine(result);
int resultInt = ConvertDecimalBinaryInt(number);
Console.WriteLine(resultInt);