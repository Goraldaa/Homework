// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координату точки по x:");
int numX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по y:");
int numY = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(numX, numY);

Console.WriteLine(quarter == 0
                ? "Указанные координаты не принадлежат опреденённой четверти" 
                : $"Данная точка принадлежит {quarter} четверти");
