// // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


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
bool ValidateLine(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else 
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
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

if (ValidateLine(numK1, numB1, numK2, numB2))
{
double numX = FindСommonX(numK1, numB1, numK2, numB2);
double numY = FindСommonY(numK1, numB1, numX);
numX = Math.Round(numX, 2);
numY = Math.Round(numY, 2);
Console.WriteLine($"Координаты точки пересечения равны ({numX}; {numY})");
}
// const double Coficient = 0;
// const double Constanta = 1;
// const double xCoord = 0;
// const double yCoord = 1;
// const double line1 = 1;
// const double line2 = 2;
// double[] lineData1 = InputLineData(line1);
// double[] lineData2 = InputLineData(line2);

// if (ValidateLine(lineData1, lineData2))
// {
//     double[] coord = CoordFind(lineData1, lineData2);
//     Console.Write($"Точка пересечения уравнений y = {lineData1[Coficient]} * x + {lineData1[Constanta]} и y = {lineData2[Coficient]} * x + {lineData2[Constanta]}");
//     Console.WriteLine($"имеет кординаты ({coord[xCoord]}, {coord[yCoord]})");
// }

// double Input(string massage)

// {
//     Console.Write(massage);
//     string value = Console.ReadLine();
//     double result = Convert.ToDouble(value);
//     return result;
// }

// double[] InputLineData(double numberOfLine)
// {
//     double[] lineData = new double[2];
//     lineData[Coficient] = Input($"Введите коффициент для {numberOfLine} - й для прямой > ");
//     lineData[Constanta] = Input($"Введите константу для {numberOfLine} - й для прямой > ");
//     return lineData;
// }

// double[] CoordFind(double[] lineData1, double[] lineData2)
// {
//     double[] coord = new double[2];
//     coord[xCoord] = (lineData1[Constanta] - lineData2[Constanta]) / (lineData2[Coficient] - lineData1[Coficient]);
//     coord[yCoord] = lineData1[Coficient] * coord[xCoord] + lineData1[Constanta];
//     return coord;
// }

// bool ValidateLine(double[] lineData1, double[] lineData2)
// {
//     if (lineData1[Coficient] == lineData2[Coficient])
//     {
//         if (lineData1[Coficient] == lineData2[Coficient])
//         {
//             Console.WriteLine("Прямые совпадают");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Прямые параллельны");
//             return false;
//         }
//     }
//     return true;
// }