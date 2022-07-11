// Напиши программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю его цифру.

Console.WriteLine ("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
    Console.WriteLine ("Неверное число");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine (n % 10);
