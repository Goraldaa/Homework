// 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool DayOffCheck(int dayNumber)
{
    return dayNumber == 6 || dayNumber == 7;
}

bool DayCheck(int dayNumber)
{
    return dayNumber > 0 && dayNumber < 8;
}

Console.WriteLine("Введите номер дня недели");
int dayNum = Convert.ToInt32(Console.ReadLine());

//такой вывод ещё премлем?

Console.WriteLine(DayCheck(dayNum) ? (DayOffCheck(dayNum) ? "Это выходной": "Это не выходной") : "В нашем мире нет такого дня недели"); 

// или лучше так?

// if(DayCheck(dayNum))                                                                       
//     Console.WriteLine(DayOffCheck(dayNum) ? "Это выходной": "Это не выходной");
// else
//     Console.WriteLine("В нашем мире нет такого дня недели");