// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* 
// СЕМИНАР_3 - ЗАДАЧА С координатами через ФУНКЦИЮ:

Console.Clear();
// 1. сначала создадим функцию для вычисления
int returnCord(int x, int y) //функцие задаем параметр integer - тип данных, чтобы она вернула целое число
{
    if (x > 0 && y > 0) { return 1; }
    else if (x < 0 && y > 0) { return 2; }
    else if (x < 0 && y < 0) { return 3; }
    else if (x > 0 && y < 0) { return 4; }
    else { return 0; }
}
// 2. запросим у пользователя переменные, конвертируем для понимания компьютеру данных
Console.WriteLine("введите координаты х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты y");
int y = Convert.ToInt32(Console.ReadLine());
// printCord(x, y);

// 3. при вызове функции два варианта:
Console.WriteLine(returnCord(x, y)); // первый вариант. печать сразу на экран

int quarter = returnCord (x, y); // второй вариант. важно сохранить куда-то результат. Задаем имя "cash.box"
Console.WriteLine($"Четверть: {quarter}");//  и после уже ее выводим на экран
*/





/* САМИНАР_3
// ЗАДАЧА17. Напишите программу, которая принимает на вход координаты точки (Х и У), 
// причем Х не равно 0 и У не равно 0 и выдает номер четверти плоскости, в которой находится эта точка

Console.Clear();
Console.WriteLine("Приветствую, друг! Введи координаты точки х и y, но они не должны быть равны нулю!");
Console.WriteLine("координата х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("координата y");
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y != 0)
{
int returnCord(int x, int y) //функцие задаем параметр integer - тип данных, чтобы она вернула целое число
{
    if (x > 0 && y > 0) { return 1; }
    else if (x < 0 && y > 0) { return 2; }
    else if (x < 0 && y < 0) { return 3; }
    else if (x > 0 && y < 0) { return 4; }
    else { return 0; }
}
int quarter = returnCord (x, y);
Console.WriteLine($"Четверть: {quarter}");
}
else 
{
Console.WriteLine("Дружок, ты ввел неверное значение. Нулей не должно быть");
}
*/




/* СЕМИНАР_3
// ЗАДАЧА 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (х и у)

Console.Clear();
Console.WriteLine("введите номер четверти");
int quarter = int.Parse(Console.ReadLine());

switch (quarter) 
{
    case 1:
    {
        Console.WriteLine("x>0, y>0");
        break;
    }
    case 2:
    {
        Console.WriteLine("x<0, y>0");
        break;
    }
    case 3:
    {
        Console.WriteLine("x<0, y<0");
        break;
    }
    case 4:
    {
        Console.WriteLine("x>0, y<0");
        break;
    }

    default:
    {
        Console.WriteLine("введено неправильное значение чертверти");
        break;
    }
}
*/


/* СЕМИНАР_3
// ЗАДАЧА 22. Напишите программу, которая принимает на вход число N и выдает таблицу квадратов 
// чисел от 1 до N.
// 5 → 1,4,9,16,25
// 2 → 1,4

Console.Clear();
Console.WriteLine("введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i<=N; i++)
{
    Console.WriteLine($"{i*i}");
}
*/



/* СЕМИНАР_3
// ЗАДАЧА 21. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.
*/
Console.Clear();
Console.Write("введите х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("введите х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("введите y2: ");
int y2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt (Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

Console.WriteLine($"расстояние={d:f2}");




