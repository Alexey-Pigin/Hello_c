






/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

Console.Clear();

Console.WriteLine("введите число ");
int a = int.Parse(Console.ReadLine());

int res = 0;

while (a > 0)
{
int num = a % 10;
a/= 10;
res+=num;
}
Console.WriteLine($"сумма всех цифр в числе равна:   {res} ");