// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* ЗАДАЧА: напишите программу, которая принимает на вход число (n) и выдает таблицу кубов чисел от 1 до n
3 -> 1,8,27
*/

Console.Clear();
Console.WriteLine("Введите число для возведение в куб: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i * i * i);
}