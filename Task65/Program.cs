
// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();
Console.WriteLine("Вводим первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим последнее число:");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumsRange(m, n);

void NaturalNumsRange(int num1, int num2)
{
  if (num1 < num2) 
  {
    Console.Write($"{num1} ");
    NaturalNumsRange(num1 + 1, num2);
  }
  else if (num1 > num2)
  {
    Console.Write($"{num1} ");
    NaturalNumsRange(num1-1, num2);
  }
  else 
  {
    Console.WriteLine(num1);
  }
}