// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите намер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = Range(quarter);
Console.WriteLine(result);

string Range(int num)
{
    if (num == 1) return "Диапазон 1 четверти: x > 0, y > 0";
    if (num == 2) return "Диапазон 2 четверти: x < 0, y > 0";
    if (num == 3) return "Диапазон 3 четверти: x < 0, y < 0";
    if (num == 4) return "Диапазон 4 четверти:x > 0, y < 0";
    return "Такая четверть не существует";
}
