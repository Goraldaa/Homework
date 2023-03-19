//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Exponentiation(int numberA, int numberB)
{
    int sum = 1;
    for (int i = 0; i < numberB; i++)
    {
        sum *= numberA;
    }
    return sum;
}

Console.WriteLine("Введите число, которое хотите возвести в степень");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень");
int numB = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} равно {result}");

