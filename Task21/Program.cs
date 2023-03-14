// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    int z = z2 - z1;
    double c = Math.Sqrt(x * x + y * y + z * z);
    return c;
}

Console.WriteLine("Введите координату первой точки по x:");
int num1X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по y:");
int num1Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по z:");
int num1Z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по x:");
int num2X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по y:");
int num2Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по z:");
int num2Z = Convert.ToInt32(Console.ReadLine());

double result = Distance(num1X, num1Y, num1Z, num2X, num2Y, num2Z);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками равно {resRound}");
