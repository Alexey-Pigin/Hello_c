

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int rec(int n, int m)
{
    if (m == n)
        return m;
    return rec(n, m-1 ) + m;
}

Console.Clear();
Console.Write("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));