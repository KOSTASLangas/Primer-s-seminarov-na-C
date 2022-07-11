// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
int a,b;
Console.WriteLine ("Введите первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
b = Convert.ToInt32(Console.ReadLine());
b = b*b;


if (a == b) Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}