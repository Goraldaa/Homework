// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100 && num <= 999) 
{
    int numLast = num % 10;
    Console.WriteLine($"Последняя цифра во введённом числе - {numLast}");
}
else 
{
    Console.WriteLine("Введено некоректное число");
}