// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2) Console.WriteLine($"Число {number1} больше числа {number2}");
else if(number1 == number2) Console.WriteLine("Числа равны");
else Console.WriteLine($"Число {number2} больше числа {number1}");