// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool IsTriangle(int a, int b, int c)
{
    if (a >= b + c) return false;
    if (b >= a + c) return false;
    if (c >= a + b) return false;
    return true;
}

Console.Clear();

Console.Write("Введите размер стороны а в теугольнике: ");
int sizeA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер стороны b в теугольнике: ");
int sizeB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер стороны c в теугольнике: ");
int sizeC = Convert.ToInt32(Console.ReadLine());

bool result = IsTriangle(sizeA, sizeB, sizeC);
Console.Write($"Треугольник со сторонаями {sizeA}, {sizeB} и {sizeC}");
Console.WriteLine(result? " существует": " не существует");