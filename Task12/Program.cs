// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Remainder(int num1, int num2)
{
     return num1 % num2;
}
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);

if (remainder == 0) Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток {remainder}");

Console.WriteLine(remainder == 0 ? "кратно" : $"не кратно, остаток {remainder}" );
