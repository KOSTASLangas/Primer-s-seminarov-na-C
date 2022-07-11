// Напиши программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке [-N,N].

int n ;
Console.WriteLine("Введите число");
n = Convert.ToInt32(Console.ReadLine());

int i = (-1) * n;

while (i <= n )
{
    Console.WriteLine(i);
    i++;

}
