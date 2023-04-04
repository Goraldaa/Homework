// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Ackermann(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = Ackermann(n, m - 1);
        n -= 1;
    }
    return m + 1;
}
bool Verification(int numberA, int numberB)
{
    return (numberA < 0 || numberB < 0);
}
Console.WriteLine("Введите целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());

if(Verification(numberN,numberM))
{
    Console.WriteLine("Введены некорректные данные");
    return;
}
int result1 = Ackermann(numberN,numberM);
Console.WriteLine($"Результат выполения функции Аккермана({numberN},{numberM}) равен: {result1}");

