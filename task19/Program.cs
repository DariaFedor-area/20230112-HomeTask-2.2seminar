// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* ЗАДАЧА 19: напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> нет
23432 -> да
*/

Console.Clear();
Console.WriteLine("введите пятизначное число и мы выясним является ли оно палинтромным:");
string str = Convert.ToString(Console.ReadLine()); // преобразуем введенное число в сроку

if (str.Length == 5) // проверка на количество символов в сроке
{
    bool isPalindrom = true; // переменная для проверки на полиндромность
    for (int i = 0; i < str.Length / 2; i++) // для перебирания символов в строке, но по 2шт в 5ти-значном числе
    {
        if (str[i] != str[str.Length - 1 - i]) // сравниваем символы вначале строки с символом вконце
        {
            isPalindrom = false;
            break;
        }
    }
    if (isPalindrom) 
    {
        Console.WriteLine("ваше число является палиндромом");
    }
    else
    {
        Console.WriteLine("ваше число не является палиндромом");
    }
}
else
{
    Console.WriteLine("вы ввели не пятизначное число. Пожалуйста, исправьте ввод");
}