// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double FindСommonX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double FindСommonY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.Clear();

Console.WriteLine("Данная программа определит координаты пересечения друх прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
Console.Write("Введите значение k1 ");
double numK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1 ");
double numB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2 ");
double numK2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2 ");
double numB2 = Convert.ToDouble(Console.ReadLine());

double numX = FindСommonX(numK1, numB1, numK2, numB2);
double numY = FindСommonY(numK1, numB1, numX);

numX = Math.Round(numX, 2);
numY = Math.Round(numY, 2);

Console.WriteLine($"Координаты точки пересечения равны ({numX};{numY})");
