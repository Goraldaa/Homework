// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49


// string input = Console.ReadLine();
// int number = Convert.ToInt32(input);


Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int squere = number * number;

Console.Write($"Кватрат числа {number} = {squere}");