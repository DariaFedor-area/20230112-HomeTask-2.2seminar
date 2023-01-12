// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* ЗАДАЧА 21: Напишите программу которая принимает на вход координаты двух точек и надозит расстояние между ними в 3D пространстве
А(3,6,8); В(2,1,-7) -> 15.84
А(7,-5,0); В(1,-1,9) -> 11.53
*/
/*
Console.Clear();

Console.WriteLine("Введите 3 цифры координаты точки A"); // запрашиваем у пользователя координаты как массив
string a = Console.ReadLine();
Console.WriteLine("Введите  3 цифры координаты точки B");
string b = Console.ReadLine();

int[] a1 = { Convert.ToInt32(a[0].ToString()), Convert.ToInt32(a[1].ToString()), Convert.ToInt32(a[2].ToString()) }; //   преобразуем символы в массив для точки А
int[] b1 = { Convert.ToInt32(b[0].ToString()), Convert.ToInt32(b[1].ToString()), Convert.ToInt32(b[2].ToString()) }; //   преобразуем символы в массив для точки В

double distance = Math.Sqrt(Math.Pow((a1[0] - b1[0]), 2) + Math.Pow((a1[1] - b1[1]), 2) + Math.Pow((a1[2] - b1[2]), 2)); //  расчет расстояния между точками А и В
Console.WriteLine("Расстояние между точками A и B = " + distance);
*/

Console.Clear();

Console.Write("Для точки А введите x координаты:"); // задаем параметры точек
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Для точки А введите y координаты:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Для точки А введите z координаты:");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Для точки B введите x координаты:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Для точки B введите y координаты:");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Для точки B введите z координаты:");
int zb = Convert.ToInt32(Console.ReadLine());



double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));// Вычисляем расстояние между точками A и B
Console.WriteLine("Расстояние между точками A и B = " + distance);

